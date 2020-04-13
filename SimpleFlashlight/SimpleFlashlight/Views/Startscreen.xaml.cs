using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace SimpleFlashlight.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Startscreen : ContentPage
    {
        public Startscreen()
        {
            InitializeComponent();
        }
        /*
        private async void Button_LightOn(object sender, EventArgs e)
        {     
            await Flashlight.TurnOnAsync();
        
            img1.Source = "lightonicon.png";     

        }

        private async void Button_LightOff(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
            img1.Source = "lightofficon.png";
        }
        */
        public async void LinkGithub(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://github.com/gthay"), BrowserLaunchMode.SystemPreferred);
        }

        public async void FlashlightHandler(object sender, EventArgs args)
        {
            bool isOn = false;


            //Is light already on?
            if (img1.Source.ToString() == "File: lightonicon.png")
            {
                isOn = true;
            }

            //
            if (isOn == true)
            {
                await Flashlight.TurnOffAsync();
                img1.Source = "lightofficon.png";
            }
            else
            {
                await Flashlight.TurnOnAsync();
                img1.Source = "lightonicon.png";
            }


        }
    }
}