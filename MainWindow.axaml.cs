using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using MessageBox.Avalonia;

namespace Hello {
	public class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		public void button_Click(object sender, RoutedEventArgs e) {
			var msg = MessageBoxManager.GetMessageBoxStandardWindow("title", "Hello " + userName.Text);
			msg.Show();
		}

		private void InitializeComponent() {
			AvaloniaXamlLoader.Load(this);
		}
	}

}
