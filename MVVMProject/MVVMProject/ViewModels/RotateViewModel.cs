using MVVMProject.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MVVMProject.ViewModels
{
    public class RotateViewModel : BaseViewModel
    {
        private readonly IMessageService _messageService;

        public RotateViewModel()
        {
            _messageService = DependencyService.Get<IMessageService>();

            Title = "Rotate";
            IsEnabled = false;

            if (VersionTracking.IsFirstLaunchEver)
            {
                _messageService.ShowAsync("Welcome TubeBuddy Interviewer", "This app was created by Edgar Flores using MVVM architecture!", "Hire Edgar :)");
            }
        }

        private string _rotatingText;
        private int _rotationValue;
        private bool _isEnabled;

        public string RotatingText
        {
            get => _rotatingText;
            set 
            {
                _rotatingText = value;
                OnPropertyChanged("RotatingText");
                // Check to enable/disable silder
                SetIsEnabled(value);
                // When Entry text is empty then the slider value and text rotation is set to 0
                if (value.Length == 0)
                    RotationValue = 0;
            }
        }

        public int RotationValue
        {
            get => _rotationValue;
            set
            {
                _rotationValue = value;
                OnPropertyChanged("RotationValue");
            }
        }

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        private void SetIsEnabled(string value)
        {
            if (value.Length == 0)
            {
                IsEnabled = false;
            }
            if (value.Length > 0)
            {
                IsEnabled = true;
            }
        }
    }
}
