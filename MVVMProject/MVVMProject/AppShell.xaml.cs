using System;
using System.Collections.Generic;
using MVVMProject.ViewModels;
using MVVMProject.Views;
using Xamarin.Forms;

namespace MVVMProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ModalView), typeof(ModalView));
        }
    }
}
