using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp1
{
    public class ExtendedWebView : WebView
    {
        public event EventHandler<string> OnLoadFile;
        public event EventHandler<string> OnLoadYouTube;
        public event EventHandler OnUnloadYouTube;

        public void LoadFile(string local)
        {
            if (OnLoadFile != null)
                this.OnLoadFile(this, local);
        }

        public void LoadYouTube(string url)
        {
            if (OnLoadYouTube != null)
                this.OnLoadYouTube(this, url);
        }

        public void UnloadYouTube()
        {
            if (OnUnloadYouTube != null)
                this.OnUnloadYouTube(this, EventArgs.Empty);
        }
    }
}
