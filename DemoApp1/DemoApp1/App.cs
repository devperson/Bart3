using DemoApp1.Pages;
using Refractored.Xam.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace DemoApp1
{
    public class App : Application
    {
        public App()
        {
            // Set the root page of your application
            var userName = CrossSettings.Current.GetValueOrDefault<string>("FirstName");
            if (userName != null)
                MainPage = new NavigationPage(new HomePage());
            else
                MainPage = new RegistrationPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
