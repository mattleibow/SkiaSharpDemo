using System.Windows;
using SkiaSharp.Views.Desktop;

namespace SkiaSharpNativeDemo.WPF
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnPainting(object sender, SKPaintSurfaceEventArgs e)
		{
			SharedPage.OnPainting(sender, e);
		}
	}
}
