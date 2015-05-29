using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp1
{
    public class BasePage : ContentPage
    {
        string lastOrientaion;
        public BasePage()
        {
            lastOrientaion = ScreenOrientaion.CurrentOrientaion;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (ScreenOrientaion.CurrentOrientaion != lastOrientaion)
            {
                lastOrientaion = ScreenOrientaion.CurrentOrientaion;

                this.OnOrientaionChanged();
            }
        }

        protected virtual void OnOrientaionChanged()
        {
            
        }
    }
}
