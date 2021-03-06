using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVMProject.Services;
using MVVMProject.Views;
using Xamarin.Essentials;

namespace MVVMProject
{
    public partial class App : Application
    {

        public App()
        {
            VersionTracking.Track();
            DependencyService.Register<Interfaces.IMessageService, Services.MessageService>();
            InitializeComponent();
            MainPage = new AppShell();
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
