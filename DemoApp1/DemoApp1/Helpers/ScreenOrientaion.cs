using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
    public class ScreenOrientaion
    {
        public static string Portrait = "Portrait";
        public static string Landscape = "Landscape";

        public static string CurrentOrientaion
        {
            get
            {
                return (App.Current.MainPage.Height > App.Current.MainPage.Width) ? Portrait : Landscape;
            }
        }
    }
}
