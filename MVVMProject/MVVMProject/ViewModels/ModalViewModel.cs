using System;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MVVMProject.ViewModels
{
    [QueryProperty(nameof(SelectedItem), nameof(SelectedItem))]
    public class ModalViewModel: BaseViewModel
    {
        public ModalViewModel()
        {
            CloseCommand = new Command(OnClose);
        }

        public Command CloseCommand { get; }
        private string _selectedItem;
        private string _deviceMeterics;

        private async void OnClose()
        {
            await Shell.Current.GoToAsync("..");
        }

        public string SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
                SetDeviceMeterics(value);
            }
        }

        public string DeviceMeterics
        {
            get => _deviceMeterics;
            set
            {
                _deviceMeterics = value;
                OnPropertyChanged("DeviceMeterics");
            }
        }

        private void SetDeviceMeterics(string value)
        {
            if (value.Equals("Connectivity"))
            {
                DeviceMeterics = SetConnectivityText();
            }

            if (value.Equals("Device Info"))
            {
                DeviceMeterics = SetDeviceInfoText();
            }

            if (value.Equals("Display Info"))
            {
                DeviceMeterics = DeviceDisplay.MainDisplayInfo.ToString();
            }
        }

        private string SetConnectivityText()
        {
            string connectivityText = "";

            var current = Connectivity.NetworkAccess;
            if (current == NetworkAccess.Internet)
            {
                connectivityText += "Network Access: Local and internet access \n";
            }
            else
            {
                connectivityText += "Network Access: No interet or limited access \n";
            }

            var profiles = Connectivity.ConnectionProfiles;
            if (profiles.Contains(ConnectionProfile.WiFi))
            {
                connectivityText += "Connection Profile: WiFi \n";
            }
            else
            {
                connectivityText += "Connection Profile: Other \n";
            }

            return connectivityText;
        }

        private string SetDeviceInfoText()
        {
            string deviceInfoText = "Model: " + DeviceInfo.Model.ToString() + " \n"
                    + "Manufacturer: " + DeviceInfo.Manufacturer.ToString() + " \n"
                    + "Device Name: " + DeviceInfo.Name.ToString() + " \n"
                    + "Operating System Version Number : " + DeviceInfo.VersionString + " \n"
                    + "Platform: " + DeviceInfo.Platform.ToString() + " \n"
                    + "Idiom: " + DeviceInfo.Idiom.ToString() + " \n"
                    + "Device Type: " + DeviceInfo.DeviceType.ToString() + " \n";
            return deviceInfoText;
        }
    }

}
