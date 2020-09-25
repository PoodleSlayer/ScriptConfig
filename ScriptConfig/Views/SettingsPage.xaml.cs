using Autofac;
using ScriptConfig.IoC;
using ScriptConfig.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScriptConfig.Views
{
	/// <summary>
	/// Interaction logic for SettingsPage.xaml
	/// </summary>
	public partial class SettingsPage : UserControl
	{
		public SettingsPage()
		{
			InitializeComponent();

			DataContext = AppContainer.Container.Resolve<SettingsViewModel>();

			BackBtn.Click += BackBtn_Click;
			FileBtn.Click += FileBtn_Click;
		}

		private void BackBtn_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
			mainWindow.MainDisplay.Content = AppContainer.Container.Resolve<MainPage>();
		}

		private void FileBtn_Click(object sender, RoutedEventArgs e)
		{
			// open file dialog
		}
	}
}
