using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp1
{
    public partial class AboutPage : BasePage
    {        
        public AboutPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            webView.LoadFile("Content/About.html");            
        }

        protected override void OnOrientaionChanged()
        {
            var webView1 = new ExtendedWebView();
            webView1.HorizontalOptions = LayoutOptions.Fill;
            webView1.VerticalOptions = LayoutOptions.Fill;
            Grid.SetRow(webView1, 1);

            var oldWebView = grid.Children.First(v => v is WebView);
            grid.Children.Remove(oldWebView);
            grid.Children.Add(webView1);

            Device.StartTimer(TimeSpan.FromSeconds(0.3), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    webView1.LoadFile("Content/About.html");
                });
                return false;
            });               
        }
        //protected override void OnSizeAllocated(double width, double height)
        //{
        //    base.OnSizeAllocated(width, height);

        //    if (ScreenOrientaion.CurrentOrientaion != lastOrientaion)
        //    {
        //        lastOrientaion = ScreenOrientaion.CurrentOrientaion;

        //        var webView1 = new ExtendedWebView();
        //        webView1.HorizontalOptions = LayoutOptions.Fill;
        //        webView1.VerticalOptions = LayoutOptions.Fill;
        //        Grid.SetRow(webView1, 1);

        //        var oldWebView = grid.Children.First(v => v is WebView);
        //        grid.Children.Remove(oldWebView);
        //        grid.Children.Add(webView1);

        //        Device.StartTimer(TimeSpan.FromSeconds(0.3), () =>
        //        {
        //            Device.BeginInvokeOnMainThread(() =>
        //            {
        //                webView1.LoadFile("Content/About.html");
        //            });
        //            return false;
        //        });               
        //    }
        //}

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }
    }
}
