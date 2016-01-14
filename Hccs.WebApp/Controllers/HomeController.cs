using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hccs.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string campus = null)
        {
            if (string.IsNullOrEmpty(campus))
            {
                return View();
            }
            else {
                HttpContext.Session["__CAMPUS"] = campus;
            }

            if (campus.Equals("ccbc", StringComparison.InvariantCultureIgnoreCase))
            {
                return View("~/Views/Home/ccbc/Index.cshtml");
            }
            else
            {
                return View("~/Views/Home/hcc/Index.cshtml");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Calendar(string campus)
        {
            string inputCampus = campus;
            if (string.IsNullOrEmpty(campus) && HttpContext.Session["__CAMPUS"] != null) inputCampus = HttpContext.Session["__CAMPUS"].ToString();

            if (string.IsNullOrEmpty(inputCampus))
            {
                return View();
            }
            else if (inputCampus.Equals("ccbc", StringComparison.InvariantCultureIgnoreCase))
            {
                return View("~/Views/Home/ccbc/Calendar.cshtml");
            }
            else
            {
                return View("~/Views/Home/hcc/Calendar.cshtml");
            }
        }

        public ActionResult Curriculum(string campus)
        {
            string inputCampus = campus;
            if (string.IsNullOrEmpty(campus) && HttpContext.Session["__CAMPUS"] != null) inputCampus = HttpContext.Session["__CAMPUS"].ToString();

            if (string.IsNullOrEmpty(inputCampus))
            {
                return View();
            }
            else if (inputCampus.Equals("ccbc", StringComparison.InvariantCultureIgnoreCase))
            {
                return View("~/Views/Home/ccbc/Curriculum.cshtml");
            }
            else
            {
                return View("~/Views/Home/hcc/Curriculum.cshtml");
            }
        }
    }
}