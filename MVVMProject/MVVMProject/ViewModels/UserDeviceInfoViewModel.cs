using System;
using MVVMProject.Views;
using Xamarin.Forms;

namespace MVVMProject.ViewModels
{
    public class UserDeviceInfoViewModel: BaseViewModel
    {
        public Command OpenCommand { get; }

        public UserDeviceInfoViewModel()
        {
           Title = "Info";
           OpenCommand = new Command(OnOpen);
        }

        private string _selectedItem;

        public string SelectedItem
        {
            get => _selectedItem;
            set {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        private async void OnOpen()
        {
            var route = $"{nameof(ModalView)}?SelectedItem={SelectedItem}";
            await Shell.Current.GoToAsync(route);
        }
    }
}
