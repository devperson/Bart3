using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp1
{
    public partial class AboutPage : ContentPage
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

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }
    }
}
