using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hccs.WebApp.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            //NOTE: By default, the current project and all referenced projects will be scanned.
            //		You can customize this by passing in a lambda to filter the assemblies by name,
            //		like so:
            //HeroicAutoMapperConfigurator.LoadMapsFromCallerAndReferencedAssemblies(x => x.Name.StartsWith("YourPrefix"));
            //HeroicAutoMapperConfigurator.LoadMapsFromCallerAndReferencedAssemblies();
        }
    }
}
