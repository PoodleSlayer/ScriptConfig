using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using ScriptConfig.IoC;
using ScriptConfig.Models;

namespace ScriptConfig
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public static SettingsModel Settings = new SettingsModel();

		public App()
		{
			AppContainer.Start();
		}

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
		}

		protected override void OnDeactivated(EventArgs e)
		{
			base.OnDeactivated(e);
		}

		protected override void OnExit(ExitEventArgs e)
		{
			base.OnExit(e);

			AppContainer.Stop();
		}
	}
}
