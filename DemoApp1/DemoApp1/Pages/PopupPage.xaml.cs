using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp1.Pages
{
    public partial class PopupPage : ContentPage
    {
        public PopupPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }
    }
}
