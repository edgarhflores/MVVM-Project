using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVMProject.Services;
using MVVMProject.Views;
using Xamarin.Essentials;
using MVVMProject.Interfaces;

namespace MVVMProject
{
    public partial class App : Application
    {
        public App()
        {
            VersionTracking.Track();
            DependencyService.Register<IMessageService, MessageService>();
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
