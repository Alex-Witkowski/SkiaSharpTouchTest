using System.ComponentModel;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace SkiaSharpTouchTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Click","Click","OK");
        }

        private void Handle_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            e.Surface.Canvas.DrawRect(e.Info.Width/2,e.Info.Height / 6, 50,50, new SKPaint{Color = Color.OrangeRed.ToSKColor()});
        }

        private async void SKCanvasView_OnTouch(object sender, SKTouchEventArgs e)
        {
            await DisplayAlert("Skia Touch","Skia Touch","OK");
            e.Handled = false;
        }
    }
}
