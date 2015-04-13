using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp1.Pages
{
    public partial class YoutubePage : ContentPage
    {
        public YoutubePage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            webView.LoadYouTube("");
            webView.UnloadYouTube();
            this.Navigation.PopAsync(true);
        }

        protected override void OnAppearing()
        {
            webView.LoadYouTube("https://www.youtube.com/embed/bulLh_-Fal8");      
        }
    }
}
