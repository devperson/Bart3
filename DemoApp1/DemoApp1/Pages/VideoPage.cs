using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp1.Pages
{
    public class VideoPage : BasePage
    {
        StackLayout topBar = new StackLayout();

        public VideoPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var backBtn = new Button() { Image = "backArrow.jpg", TextColor = Color.White, Font = Font.BoldSystemFontOfSize(23), VerticalOptions = LayoutOptions.Fill, HorizontalOptions = LayoutOptions.Start, WidthRequest = 40 };
            backBtn.Clicked += backBtn_Clicked;            
            topBar.VerticalOptions = LayoutOptions.Start;
            topBar.HorizontalOptions = LayoutOptions.Fill;
            topBar.BackgroundColor = Color.Black;
            topBar.Children.Add(backBtn);
            topBar.Padding = new Thickness(15, 20, 0, 0);
            topBar.HeightRequest = 60;

            this.Content = topBar;
        }

        private void backBtn_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PopAsync(true);
        }

        protected override void OnOrientaionChanged()
        {
            topBar.IsVisible = ScreenOrientaion.CurrentOrientaion == ScreenOrientaion.Portrait;
        }
    }
}
