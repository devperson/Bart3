using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemoApp1.Pages
{
    public partial class RegistrationPage : ContentPage
    {
        RegisterViewModel vm;
        public RegistrationPage()
        {
            InitializeComponent();

            vm = new RegisterViewModel();
            this.BindingContext = vm;
        }

        private void btnReg_Clicked(object sender, EventArgs e)
        {
            try
            {
                vm.SaveUser();
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            catch (Exception ex)
            {
                this.DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
