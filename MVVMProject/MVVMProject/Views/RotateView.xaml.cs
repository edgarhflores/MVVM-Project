using MVVMProject.ViewModels;
using Xamarin.Forms;

namespace MVVMProject.Views
{
    public partial class RotateView : ContentPage
    {
        public RotateView()
        {
            InitializeComponent();
            BindingContext = new RotateViewModel();
        }
    }
}
