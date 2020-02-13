using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MinimalistAlphabet
{
    public partial class App : Application
    {
        public static bool HasLoadedBefore { get; set; } = false;
        public static string Selection { get; set; }

        public App()
        {
            InitializeComponent();

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
