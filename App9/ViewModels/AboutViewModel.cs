using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App9.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {





            /*
             * 26.04.2022
                        Title = "Ярослава";
                        //            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            //            OpenWebCommand = new Command(async () => await Browser.OpenAsync("google.com"));
                        OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=8kDmvD-KpK8")); // BrowserLaunchMode.SystemPreferred
                        OpenWebCommand2 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=vx88ExjBt8s&t=2895s"));
                        OpenWebCommand3 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=cTfxennz3xU"));
                        OpenWebCommand4 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=gUCxVL45C3g&list=RDcTfxennz3xU&index=13"));
                        OpenWebCommand5 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=CpmDAu_47OE"));
                        OpenWebCommand6 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=XPNnrw8VT4k"));
                        OpenWebCommand7 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=X94onZzN-tw&list=RDX94onZzN-tw&t=129s"));
                        OpenWebCommand8 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=UMVjToYOjbM"));
            */
            Title = "SamarinAlex";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/SamarinAlex/Putin/wiki")); // BrowserLaunchMode.SystemPreferred
            OpenWebCommand2 = new Command(async () => await Browser.OpenAsync("https://github.com/SamarinAlex/Putin/wiki/Бен-Уоллес"));
            OpenWebCommand3 = new Command(async () => await Browser.OpenAsync("https://github.com/SamarinAlex/Putin/wiki/Бен-Уоллес-Государственный-секретарь-по-обороне"));
/*
            OpenWebCommand4 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=gUCxVL45C3g&list=RDcTfxennz3xU&index=13"));
            OpenWebCommand5 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=CpmDAu_47OE"));
            OpenWebCommand6 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=XPNnrw8VT4k"));
            OpenWebCommand7 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=X94onZzN-tw&list=RDX94onZzN-tw&t=129s"));
            OpenWebCommand8 = new Command(async () => await Browser.OpenAsync("https://www.youtube.com/watch?v=UMVjToYOjbM"));
*/

        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenWebCommand2 { get; }
        public ICommand OpenWebCommand3 { get; }

/*
        public ICommand OpenWebCommand4 { get; }
        public ICommand OpenWebCommand5 { get; }
        public ICommand OpenWebCommand6 { get; }
        public ICommand OpenWebCommand7 { get; }
        public ICommand OpenWebCommand8 { get; }

*/

        /*
                        public async Task OpenBrowser(Uri uri)
                        {
                            try
                            {
                                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
                            }
                            catch (Exception ex)
                            {
                                // An unexpected error occured. No browser may be installed on the device.
                            }
                        }
                */
    }
}