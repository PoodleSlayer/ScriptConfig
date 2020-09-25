using Autofac;
using ScriptConfig.IoC;
using ScriptConfig.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ScriptConfig.Views
{
	/// <summary>
	/// Interaction logic for MainPage.xaml
	/// </summary>
	public partial class MainPage : UserControl
	{
		public MainPage()
		{
			InitializeComponent();

			DataContext = AppContainer.Container.Resolve<MainViewModel>();

			SettingsBtn.Click += SettingsBtn_Click;
		}

		private void SettingsBtn_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
			mainWindow.MainDisplay.Content = AppContainer.Container.Resolve<SettingsPage>();
		}
	}
}
