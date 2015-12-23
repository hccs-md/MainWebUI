using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hccs.WebApp.Controllers
{
    public class ProfileController : HccsBaseController
    {
        private readonly ApplicationUserManager _userManager;
        public ProfileController(ApplicationUserManager userManager)
        {
            _userManager = userManager;
        }
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

    }
}