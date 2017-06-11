using Android.App;
using Android.OS;
using Android.Support.V7.App;
using SkiaSharp.Views.Android;

namespace SkiaSharpNativeDemo.Droid
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.DarkActionBar")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.main);

			var canvasView = FindViewById<SKCanvasView>(Resource.Id.canvasView);
			canvasView.PaintSurface += OnPaintSurface;
		}

		private void OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
		{
			SharedPage.OnPainting(sender, e);
		}
	}
}
