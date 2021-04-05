using System.Windows;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using MessageBox.Avalonia;

namespace Hello {
	
	public partial class MainWindow : Window {
		public MainWindow() {
			this.InitializeComponent();
			
// #if DEBUG
// 			this.AttachDevTools();
// #endif
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			var userName = this.FindControl<TextBox>("userName");
			var msg = MessageBoxManager.GetMessageBoxStandardWindow("title", "Hello " + userName.Text);
			msg.Show();
		}

		private void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}

}
