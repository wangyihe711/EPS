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

        public int PatrolRouteId { get; set; }

        public string PatrolRouteName { get; set; }

        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public DateTime SchemeDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string DateRange { get; set; }
    }
}