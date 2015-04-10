using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.IO;

[assembly: ExportRenderer(typeof(DemoApp1.ExtendedWebView), typeof(DemoApp1.iOS.ExWebViewRenderer))]
namespace DemoApp1.iOS
{

    public class ExWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                (e.OldElement as ExtendedWebView).OnLoadFile += element_OnLoadFile;
            }

            var element = e.NewElement as ExtendedWebView;
            element.OnLoadFile += element_OnLoadFile;
            element.OnLoadYouTube += element_OnLoadYouTube;
        }

        void element_OnLoadFile(object sender, string e)
        {            
            string localHtmlUrl = Path.Combine(NSBundle.MainBundle.BundlePath, e);
            this.LoadRequest(new NSUrlRequest(new NSUrl(localHtmlUrl, false)));
            this.ScalesPageToFit = false;
        }

        void element_OnLoadYouTube(object sender, string e)
        {
            string localHtmlUrl = Path.Combine(NSBundle.MainBundle.BundlePath, "Content/YouTube.html");
            var htmlText = File.ReadAllText(localHtmlUrl);

            htmlText = htmlText.Replace("$('#video').attr('src', 'https://www.youtube.com/embed/bulLh_-Fal8');", string.Format("$('#video').attr('src', '{0}');", e));
            this.LoadHtmlString(htmlText, null);
        }
    }
}