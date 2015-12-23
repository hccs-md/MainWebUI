using Hccs.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Hccs.WebApp.Controllers
{
    public class PersonController : HccsBaseController
    {
        private readonly ApplicationUserManager _userManager;
        public PersonController(ApplicationUserManager userManager)
        {
            _userManager = userManager;
        }

        public async Task<ActionResult> Index(string familyId, int personId = -1)
        {
            string currentUserId = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
            if (currentUserId == familyId || User.IsInRole("Admin"))
            {
                PersonForm pf = new PersonForm() { ParentId = familyId }; //use repository to get person
                return View(pf);
            }
            else
            {
                return View("NotAuthorized");
            }
        }
    }
}
