using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp1.Pages
{
    public partial class HomePage : ContentPage
    {
        bool isFirstTimeLoad = true;            
        public HomePage()
        {            
            InitializeComponent();
			            
            NavigationPage.SetHasNavigationBar(this, false);
        }

        //public void btnYouTube_Clicked(object sender, EventArgs e)
        //{
        //    this.Navigation.PushAsync(new YoutubePage(), true);           
        //}

        public void btnVideo_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new VideoPage(), true);
        }

        public void btnAbout_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AboutPage(), true);
        }

        public void btnCompany_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new CompanyPage(), true);
        }

        public void btnPopup_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new PopupPage(), true);
        }
    }
}
