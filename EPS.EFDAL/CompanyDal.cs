using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPS.Model;
using EPS.Common;

namespace EPS.EFDAL
{

    /// <summary>
    /// 类名称：CompanyDal
    /// 命名空间：EPS.EFDAL
    /// 类功能：
    /// </summary>
    /// 创建者：叶烨星
    /// 创建时间：2018/1/23 20:42
    /// 修改者：叶烨星
    /// 修改时间：2018/1/23 20:42
    public class CompanyDal : BaseDal<Company>
    {
        //上下文
        DataModelContainer db = new DataModelContainer();

        /// <summary>
        /// 通过id获取公司
        /// </summary>
        /// <param name="id">公司id</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/23 20:42
        /// 修改者：叶烨星
        /// 修改时间：2018/1/23 20:42
        public ServiceResult<Company> GetCompanyById(int id)
        {
            if (id <= 0)
            {
                return new ServiceResult<Company>
                {
                    State = false,
                    Message = "输入的id不合法"
                };
            }

            Company company = db.Company.Find(id);

            if (company == null)
            {
                return new ServiceResult<Company>
                {
                    State = false,
                    Message = "该公司不存在"
                };
            }
            return new ServiceResult<Company>
            {
                Result = company,
                State = true
            };
        }

        /// <summary>
        /// 获取公司列表
        /// </summary>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/23 21:07
        /// 修改者：叶烨星
        /// 修改时间：2018/1/23 21:07
        public ServiceResultList<Company> GetCompanyList()
        {
            List<Company> companyList = db.Company.ToList();
            return new ServiceResultList<Company>
            {
                Result = companyList,
                State = true
            };
        }

        /// <summary>
        /// 添加公司
        /// </summary>
        /// <param name="company">公司</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/23 20:47：
        /// 修改者：叶烨星
        /// 修改时间：2018/1/23 20:47
        public ServiceResult<bool> AddCompany(Company company)
        {
            if (company == null)
            {
                return new ServiceResult<bool>
                {
                    State = false,
                    Message = "公司信息不能为空"
                };
            }

            db.Company.Add(company);
            db.SaveChanges();

            return new ServiceResult<bool>
            {
                State = true,
                Result = true
            };
        }

        /// <summary>
        /// 通过id删除公司
        /// </summary>
        /// <param name="id">公司id</param>
        /// <returns></returns>
        /// 创建者：叶烨星
        /// 创建时间：2018/1/23 20:50
        /// 修改者：叶烨星
        /// 修改时间：2018/1/23 20:50
        public ServiceResult<bool> DeleteCompanyById(int id)
        {
            if (id <= 0)
            {
                return new ServiceResult<bool>
                {
                    State = false,
                    Message = "输入的id不合法"
                };
            }

            Company company = db.Company.Find(id);

            if (company == null)
            {
                return new ServiceResult<bool>
                {
                    State = false,
                    Message = "该公司不存在"
                };
            }

            db.Company.Remove(company);

            return new ServiceResult<bool>
            {
                Result = true,
                State = true
            };
        }
    }
}
