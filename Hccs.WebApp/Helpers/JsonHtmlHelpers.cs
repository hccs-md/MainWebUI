using Hccs.WebApp.Infrastructures;
using System.Web;
using System.Web.Mvc;

namespace Hccs.WebApp.Helpers
{
    public static class JsonHtmlHelpers
    {
        public static IHtmlString JsonFor<T>(this HtmlHelper helper, T obj)
        {
            return helper.Raw(obj.ToJson());
        }
    }
}
