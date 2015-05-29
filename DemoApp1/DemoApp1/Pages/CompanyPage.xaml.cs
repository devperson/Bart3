using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp1
{
    public partial class CompanyPage : BasePage
    {
        public CompanyPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            webView.LoadFile("Content/Company.html");
        }


        //reload web view on orientation change.
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
                    webView1.LoadFile("Content/Company.html");
                });
                return false;
            });
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }
    }
}
