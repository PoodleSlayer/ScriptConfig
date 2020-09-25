using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ScriptConfig.Controls
{
	public class SCSelectTextBox : TextBox
	{
		public SCSelectTextBox()
		{
			AddHandler(PreviewMouseLeftButtonDownEvent, new MouseButtonEventHandler(TakeFocus), true);
			AddHandler(GotKeyboardFocusEvent, new RoutedEventHandler(SelectAllText), true);
			AddHandler(MouseDoubleClickEvent, new RoutedEventHandler(SelectAllText), true);
		}

		private static void TakeFocus(object sender, MouseButtonEventArgs e)
		{
			DependencyObject parent = e.OriginalSource as UIElement;
			while (parent != null && !(parent is TextBox))
			{
				parent = VisualTreeHelper.GetParent(parent);
			}

			if (parent != null)
			{
				var textBox = (TextBox)parent;
				if (!textBox.IsKeyboardFocusWithin)
				{
					textBox.Focus();
					e.Handled = true;
				}
			}
		}

		private static void SelectAllText(object sender, RoutedEventArgs e)
		{
			var textBox = e.OriginalSource as TextBox;
			if (textBox != null)
			{
				textBox.SelectAll();
			}
		}
	}
}
