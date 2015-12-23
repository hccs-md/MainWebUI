﻿using System;
using System.Web;
using StructureMap;

namespace Heroic.Web.IoC
{
	public class StructureMapContainerPerRequestModule : IHttpModule
	{
		public static event Action<IContainer> PreDisposeContainer;

		public static IContainer Container
		{
			get
			{
				return new HttpContextWrapper(HttpContext.Current).GetContainer();
			}
			set
			{
				new HttpContextWrapper(HttpContext.Current).SetContainer(value);
			}
		}

		public void Init(HttpApplication context)
		{
			context.BeginRequest += CreateContainer;
			context.EndRequest += DisposeOfContainer;
			
			//Ensures the event is always defined.
			PreDisposeContainer += _ => { };
		}

		private void CreateContainer(object sender, EventArgs e)
		{
			Container = IoC.Container.GetNestedContainer();
		}

		private void DisposeOfContainer(object sender, EventArgs e)
		{
			try
			{
				PreDisposeContainer(Container);
			}
			finally
			{
				if (Container.Role != ContainerRole.Root)
				{
					Container.Dispose();
					Container = null;
				}
			}
		}

		public void Dispose()
		{
			return;
		}
	}
}