# SkiaSharp Demo App

This is just a set of simple demonstration apps, each of which show
how to do a few tasks using SkiaSharp:

 * Add the `<SKCanvasView>` (for Xamarin.Forms) to a page
 * Attach a handler to the `PaintSurface` event
 * Clear the canvas
 * Create a `SKPaint` instance
 * Draw a simple circle
 * Draw a `SKPath`
 * Draw text


<img width="357" height="357" alt="Final Drawing" src="https://s3.amazonaws.com/blog.xamarin.com/wp-content/uploads/2017/01/26223214/circle-cross-text-cropped.png">


## SkiaSharpDemo

This is a Xamarin.Forms sample app. It draws the image onto a Xamarin.Forms
`SKCanvasView` with a XAML UI.

## SkiaSharpConsoleDemo

This is a .NET console sample app. It draws the image in memory and then 
saves the file to `output.png`.

## SkiaSharpNativeDemo

This is a set of Xamarin.Android, Xamarin.iOS and UWP sample apps. 

They each draw the image onto a platform-speciific view (`SKCanvasView` for iOS 
and Android or `SKXamlCanvas` for UWP).

Each platform uses their specific UI designers (AXML for Android, 
storyboards for iOS and XAML for UWP).
