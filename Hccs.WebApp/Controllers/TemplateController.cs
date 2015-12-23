using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Hccs.WebApp.Controllers
{
    public class TemplateController : HccsBaseController
    {
        public PartialViewResult Render(string feature, string name)
        {
            return PartialView(string.Format("~/js/app/{0}/templates/{1}", feature, name));
        }
    }
}
