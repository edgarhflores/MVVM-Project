using MVVMProject.Views;
using Xamarin.Forms;

namespace MVVMProject.ViewModels
{
    public class UserDeviceInfoViewModel: BaseViewModel
    {
        public UserDeviceInfoViewModel()
        {
           Title = "Info";
           OpenCommand = new Command(OnOpen);
        }

        public Command OpenCommand { get; }
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
            if (SelectedItem == null)
            {
                SelectedItem = "Please Go Back and Select a Category to View";
            }
            var route = $"{nameof(ModalView)}?SelectedItem={SelectedItem}";
            await Shell.Current.GoToAsync(route);
        }
    }
}
