using Autofac;
using ScriptConfig.ViewModels;
using ScriptConfig.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptConfig.IoC
{
	public static class AppContainer
	{
		private static IContainer container;

		public static IContainer Container
		{
			get
			{
				if (container == null)
				{
					Start();
				}

				return container;
			}
		}

		public static void Start()
		{
			if (container != null)
			{
				return;
			}

			var containerBuilder = new ContainerBuilder();
			RegisterDependencies(containerBuilder);
			container = containerBuilder.Build();
		}

		public static void Stop()
		{
			container.Dispose();
		}

		private static void RegisterDependencies(ContainerBuilder cb)
		{
			// Views
			cb.RegisterType<MainPage>().SingleInstance();
			cb.RegisterType<SettingsPage>().SingleInstance();

			// ViewModels
			cb.RegisterType<MainViewModel>().SingleInstance();
			cb.RegisterType<SettingsViewModel>().SingleInstance();

			// Utilities/Services
		}
	}
}
