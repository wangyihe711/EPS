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
  
    public class TransactionController : BaseController
    {
        PatrolSchemeService bll = new PatrolSchemeService();
        PatrolReportService bll1 = new PatrolReportService();
        
        public ActionResult SchemeList()
        {
            
            List<PatrolScheme> patrolSchemeList = bll.GetElementList().Result;
            List<PatrolSchemeModel> modelList = new List<PatrolSchemeModel>();

            foreach (var item in patrolSchemeList)
            {
                PatrolSchemeModel model = new PatrolSchemeModel()
                {
                    Id = item.Id,
                    Number = item.Number,
                    DefectTypeId = item.DefectTypeId,
                    DefectCode = item.Dictionary.Code,
                    DefectType = item.Dictionary.Type,
                    EmployeeId = item.EmployeeId,
                    EmployeeName = item.Employee.Name,
                    PatrolRouteId = item.PatrolRouteId,
                    PatrolRouteName = item.PatrolRoute.Name,
                    SchemeDate = item.SchemeDate,
                    StartDate = item.StartDate,
                    EndDate = item.EndDate
                };
                modelList.Add(model);
            }
        
            ViewBag.Model = modelList;
            return View();
        }
       
        public ActionResult ResultList()
        {
            List<PatrolReport> patrolReportList = bll1.GetElementList().Result;
            List<PatrolReportModel> modelList = new List<PatrolReportModel>();

            foreach (var item in patrolReportList)
            {
                PatrolReportModel model = new PatrolReportModel()
                {

                    PoleTowerName = item.PatrolPoint.PoleTowerNumber,
                    DefectCode = item.Dictionary.Code,
                    DefectType = item.Dictionary.Type,
                    PatrolRouteName = item.PatrolRoute.Name,
                    ReportTime = item.ReportTime,
                };
                modelList.Add(model);
            }

            ViewBag.Model = modelList;
            return View();
        }
    }
}