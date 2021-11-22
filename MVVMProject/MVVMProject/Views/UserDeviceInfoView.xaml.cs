using System;
using System.Collections.Generic;
using MVVMProject.ViewModels;
using Xamarin.Forms;

namespace MVVMProject.Views
{
    public partial class UserDeviceInfoView : ContentPage
    {
        public UserDeviceInfoView()
        {
            InitializeComponent();
            BindingContext = new UserDeviceInfoViewModel();
        }
    }
}
