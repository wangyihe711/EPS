using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPS.UI.Portal.Models
{
    public class PatrolReportModel
    {
        public string DefectCode { get; set; }

        public string DefectType { get; set; }

        public int PatrolRouteId { get; set; }

        public string PatrolRouteName { get; set; }
       
        public string PoleTowerName { get; set; }

        public DateTime ReportTime { get; set; }
    }
}