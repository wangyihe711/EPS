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
    public class CompanyService
    {
        CompanyDal dal = new CompanyDal();

        public ServiceResult<Company> GetCompanyById(int id)
        {
            return dal.GetCompanyById(id);
        }
    }
}
