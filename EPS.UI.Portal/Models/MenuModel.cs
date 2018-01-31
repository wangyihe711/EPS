using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPS.UI.Portal.Models
{
    public class MenuModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int ParentId { get; set; }

        public string Link { get; set; }

        public List<MenuModel> Children { get; set; }

        public MenuModel()
        {
            Children = new List<MenuModel>();
        }
    }
}