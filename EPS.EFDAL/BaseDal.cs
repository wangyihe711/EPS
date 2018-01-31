using EPS.Common;
using EPS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EPS.EFDAL
{
    public class BaseDal<T> where T : class, new()
    {
        DataModelContainer db = new DataModelContainer();

        /// <summary>
        /// Gets the element by id.
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/28 18:47
        /// 修改者：
        /// 修改时间：
        public ServiceResult<T> GetElementById(int id)
        {
            if (id <= 0)
            {
                return new ServiceResult<T>
                {
                    State = false,
                    Message = "输入的id不合法"
                };
            }

            T element = db.Set<T>().Find(id);
            if (element == null)
            {
                return new ServiceResult<T>
                {
                    State = false,
                    Message = "该元素不存在"
                };
            }

            return new ServiceResult<T>
            {
                Result = element,
                State = true
            };
        }

        /// <summary>
        /// Gets the element list.
        /// </summary>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/28 19:29
        /// 修改者：
        /// 修改时间：
        public ServiceResultList<T> GetElementList()
        {
            return new ServiceResultList<T>
            {
                Result = db.Set<T>().ToList(),
                State = true
            };
        }

        /// <summary>
        /// Gets the element list.
        /// </summary>
        /// <param name="whereLambda">The where lambda.</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/28 18:50
        /// 修改者：
        /// 修改时间：
        public ServiceResultList<T> GetElementList(Expression<Func<T, bool>> whereLambda = null)
        {
            return new ServiceResultList<T>
            {
                Result = db.Set<T>().Where(whereLambda).ToList(),
                State = true
            };
        }

        /// <summary>
        /// Adds the specified element.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/28 18:53
        /// 修改者：
        /// 修改时间：
        public ServiceResult<bool> Add(T element)
        {
            db.Set<T>().Add(element);
            try
            {
                db.SaveChanges();
                return new ServiceResult<bool>
                {
                    Result = true,
                    State = true
                };
            }
            catch (Exception e)
            {
                return new ServiceResult<bool>
                {
                    State = false,
                    Message = e.ToString()
                };
            }
        }

        /// <summary>
        /// Deletes the by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/28 18:59
        /// 修改者：
        /// 修改时间：
        public ServiceResult<bool> DeleteById(int id)
        {
            ServiceResult<T> result = GetElementById(id);
            if (!result.State)
            {
                return new ServiceResult<bool>
                {
                    State = false,
                    Message = result.Message
                };
            }

            db.Set<T>().Remove(result.Result);
            db.SaveChanges();

            return new ServiceResult<bool>
            {
                Result = true,
                State = true
            };
        }
    }
}
