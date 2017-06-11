using System;
using UIKit;
using SkiaSharp.Views.iOS;

namespace SkiaSharpNativeDemo.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController(IntPtr handle)
			: base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			canvasView.PaintSurface += OnPainting;
		}

		private void OnPainting(object sender, SKPaintSurfaceEventArgs e)
		{
			SharedPage.OnPainting(sender, e);
		}
	}
}
