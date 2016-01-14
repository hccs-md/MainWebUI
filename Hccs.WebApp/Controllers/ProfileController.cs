using AutoMapper;
using Hccs.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Index()
        {
            var model = Mapper.Map<PersonForm>(await _userManager.FindByIdAsync(User.Identity.Name));
            return View(model);
        }

        public async Task<JsonResult> Update(PersonForm form)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Email = form.Email;
            user.Person = Mapper.Map<Person>(form);
                        
            await _userManager.UpdateAsync(user);

            return Json(true);
        }
    }
}