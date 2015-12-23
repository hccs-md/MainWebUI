using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hccs.WebApp.Startup))]
namespace Hccs.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
