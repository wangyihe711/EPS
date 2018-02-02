using EPS.BLL;
using EPS.Model;
using EPS.UI.Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EPS.UI.Portal.Controllers
{
    /// <summary>
    /// 类名称：SysmanageController
    /// 命名空间：EPS.UI.Portal.Controllers
    /// 创建者：王一鹤
    /// 创建日期：2018/2/2
    /// </summary>
    /// <seealso cref="EPS.UI.Portal.Controllers.BaseController" />
    public class SysmanageController : BaseController
    {
        EmployeeService bll = new EmployeeService();
     
        public ActionResult Staff()
        {
            
            List<Employee> employeeList = bll.GetElementList().Result;
            List<EmployeeModel> modelList = new List<EmployeeModel>();

            foreach (var item in employeeList)
            {
                EmployeeModel model = new EmployeeModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    GroupName = item.Group.Name,
                    GroupId = item.GroupId,
                    DepartmentName = item.Department.Name,
                    DepartmentId = item.Department.Id,
                    CompanyName = item.Company.Name,
                    CompanyId = item.CompanyId,
                };
                modelList.Add(model);
            }

            ViewBag.Model = modelList;
            return View();

        }

      
        public ActionResult Department()
        {
            List<Employee> employeeList = bll.GetElementList().Result;
            List<EmployeeModel> modelList = new List<EmployeeModel>();

            foreach (var item in employeeList)
            {
                EmployeeModel model = new EmployeeModel()
                {

                    GroupName = item.Group.Name,
                    GroupId = item.GroupId,
                    DepartmentName = item.Department.Name,
                    DepartmentId = item.Department.Id,
                    CompanyName = item.Company.Name,
                    CompanyId = item.Company.Id,
                };
                modelList.Add(model);
            }

            ViewBag.Model = modelList;
            return View();
        }        
       public ActionResult Group()
        {
            List<Employee> employeeList = bll.GetElementList().Result;
            List<EmployeeModel> modelList = new List<EmployeeModel>();

            foreach (var item in employeeList)
            {
                EmployeeModel model = new EmployeeModel()
                {
                    
                    GroupName = item.Group.Name,
                    GroupId = item.Group.Id,
                    DepartmentName = item.Department.Name,
                    DepartmentId = item.Department.Id,
                    CompanyName = item.Company.Name,
                    CompanyId = item.CompanyId,
                };
                modelList.Add(model);
            }

            ViewBag.Model = modelList;
            return View();
        }
    }
}