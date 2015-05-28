using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(DemoApp1.Pages.VideoPage), typeof(DemoApp1.iOS.Renderer.VideoPageRenderer))]
namespace DemoApp1.iOS.Renderer
{
    public class VideoPageRenderer : PageRenderer
    {
        PlayerViewController playerController;
        testViewCtrl testCtrl;
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            playerController = new PlayerViewController();
            base.OnElementChanged(e);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var view = NativeView;

            playerController = new PlayerViewController();
            playerController.WillMoveToParentViewController(this);
            this.AddChildViewController(playerController);
            this.View.InsertSubview(playerController.View, 0);
            //this.View.AddSubview(playerController.View);
            playerController.DidMoveToParentViewController(this);
        }
       
        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();           

            playerController.View.Frame = new CGRect(this.NativeView.Frame.X, this.NativeView.Frame.Y, this.NativeView.Frame.Width, this.NativeView.Frame.Height);

            //need wait for recalc autolayouts for player frame
            Device.StartTimer(TimeSpan.FromSeconds(0.3), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    playerController.UpdateVideoFrame();
                });

                return false;
            });
        }                      
    }
}