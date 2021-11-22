using System;
using System.Collections.Generic;
using MVVMProject.ViewModels;
using Xamarin.Forms;

namespace MVVMProject.Views
{
    public partial class ModalView : ContentPage
    {
        public ModalView()
        {
            InitializeComponent();
            BindingContext = new ModalViewModel();
        }
    }
}
