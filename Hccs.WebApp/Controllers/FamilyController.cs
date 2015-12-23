using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hccs.WebApp.Controllers
{
    [Authorize]
    public class FamilyController : HccsBaseController
    {
        // GET: Family
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult AddMember()
        {
            return View();
        }

        public ActionResult Notifications()
        {
            return View();
        }
    }
}