using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Hccs.WebApp.Controllers
{
    public class NavigationController : Controller
    {
        [ChildActionOnly]
        public ActionResult Menu()
        {
            if (Roles.IsUserInRole("Admin"))
            {
                return PartialView("_loginPartialAdmin");
            }
            else if (Roles.IsUserInRole("Teacher"))
            {
                return PartialView("_loginPartialTeacher");
            }
            else
            {
                return PartialView("_loginPartial");
            }
        }
    }
}