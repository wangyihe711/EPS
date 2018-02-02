using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPS.UI.Portal.Models
{
    public class PatrolSchemeModel
    {

        public int Id { get; set; }

        public string Number { get; set; }

        public int DefectTypeId { get; set; }

        public string DefectCode { get; set; }

        public string DefectType { get; set; }

        public int PatrolRouteId { get; set; }

        public string PatrolRouteName { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public DateTime SchemeDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


    }
}