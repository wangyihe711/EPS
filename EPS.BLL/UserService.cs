using EPS.Common;
using EPS.EFDAL;
using EPS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS.BLL
{
    public class UserService : BaseService<User>
    {
        UserDal dal = new UserDal();

        public ServiceResult<bool> Login(string username, string password)
        {
            return dal.Login(username, password);
        }
    }
}
