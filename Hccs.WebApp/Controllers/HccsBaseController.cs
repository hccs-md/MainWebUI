using Hccs.WebApp.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Hccs.WebApp.Controllers
{
    public abstract class HccsBaseController : Controller
    {
        public BetterJsonResult<T> BetterJson<T>(T model)
        {
            return new BetterJsonResult<T> { Data = model };
        }
    }
}
