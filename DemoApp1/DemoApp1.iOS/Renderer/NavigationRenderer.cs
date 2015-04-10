using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(DemoApp1.iOS.NavigationPageRenderer))]
namespace DemoApp1.iOS
{
    public class NavigationPageRenderer : NavigationRenderer, IUIGestureRecognizerDelegate
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.InteractivePopGestureRecognizer.Delegate = this;
            this.WeakDelegate = new NavigationDelegate();
        }

        public override void PushViewController(UIViewController viewController, bool animated)
        {
            this.InteractivePopGestureRecognizer.Enabled = false;
            base.PushViewController(viewController, animated);
        }
    }

    public class NavigationDelegate : UINavigationControllerDelegate
    {
        public override void DidShowViewController(UINavigationController navigationController, UIViewController viewController, bool animated)
        {
            navigationController.InteractivePopGestureRecognizer.Enabled = true;
        }
    }
}

