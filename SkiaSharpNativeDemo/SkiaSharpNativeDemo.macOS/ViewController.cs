using System;
using AppKit;
using SkiaSharp.Views.Mac;

namespace SkiaSharpNativeDemo.macOS
{
	public partial class ViewController : NSViewController
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
