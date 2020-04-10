using MultiIdiomaStarter.DependencyServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MultiIdiomaStarter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // configurar el idioma del dispositivo usando un servicio de dependencia
            if (Device.RuntimePlatform == Device.iOS || Device.RuntimePlatform == Device.Android)
            {
                var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                DependencyService.Get<ILocalize>().SetLocale(ci);
            }

            MainPage = new MainPage();
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
