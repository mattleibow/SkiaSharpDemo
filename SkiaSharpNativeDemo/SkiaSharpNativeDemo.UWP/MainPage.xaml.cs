using SkiaSharp.Views.UWP;
using Windows.UI.Xaml.Controls;

namespace SkiaSharpNativeDemo.UWP
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void OnPainting(object sender, SKPaintSurfaceEventArgs e)
		{
			SharedPage.OnPainting(sender, e);
		}
	}
}
