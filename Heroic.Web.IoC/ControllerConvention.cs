using System;
using System.Web.Mvc;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Graph.Scanning;
using StructureMap.Pipeline;
using StructureMap.TypeRules;

namespace Heroic.Web.IoC
{
	public class ControllerConvention : IRegistrationConvention
	{
        public void ScanTypes(TypeSet types, Registry registry)
        {
            foreach(Type type in types.AllTypes())
            {
                Process(type, registry);
            }
        }

        public void Process(Type type, Registry registry)
		{
			if (type.CanBeCastTo(typeof(Controller)) && !type.IsAbstract)
			{
				registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
			}
		}        
    }
}