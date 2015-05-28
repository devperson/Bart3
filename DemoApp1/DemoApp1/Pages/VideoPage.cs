using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp1.Pages
{
    public class VideoPage : ContentPage
    {
        public VideoPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);


            var backBtn = new Button() { Text = "<", TextColor = Color.White, Font = Font.BoldSystemFontOfSize(23), VerticalOptions = LayoutOptions.Fill, HorizontalOptions = LayoutOptions.Start, WidthRequest = 40 };
            backBtn.Clicked += backBtn_Clicked;
            var stack = new StackLayout();
            stack.VerticalOptions = LayoutOptions.Start;
            stack.HorizontalOptions = LayoutOptions.Fill;
            stack.BackgroundColor = Color.FromRgba(0, 0, 0, 0.6);
            stack.Children.Add(backBtn);
            stack.Padding = new Thickness(15, 0, 0, 0);
            stack.HeightRequest = 50;

            this.Content = stack;
        }

        private void backBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }
    }
}
