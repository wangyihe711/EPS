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
    public class BaseController : Controller
    {
        MenuService bll = new MenuService();

        public BaseController()
        {
            List<Menu> menuList = bll.GetElementList().Result;
            List<MenuModel> modelList = new List<MenuModel>();
            foreach (var menu in menuList)
            {
                MenuModel model = new MenuModel
                {
                    Id = menu.Id,
                    Name = menu.Name,
                    ParentId = menu.ParentId,
                    Link = menu.Link,
                    Children = new List<MenuModel>()
                };

                if (menu.ParentId == 0)
                {
                    modelList.Add(model);
                    continue;
                }

                var parent = modelList.Find(u => u.Id == menu.ParentId);
                parent.Children.Add(model);

            }

            ViewBag.nav = modelList;
        }
    }
}