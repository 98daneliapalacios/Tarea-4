using System;
using Tarea_4.Services;
using Tarea_4.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_4
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
