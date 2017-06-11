// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SkiaSharpNativeDemo.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        SkiaSharp.Views.iOS.SKCanvasView canvasView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (canvasView != null) {
                canvasView.Dispose ();
                canvasView = null;
            }
        }
    }
}