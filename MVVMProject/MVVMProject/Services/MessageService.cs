using System;
using System.Threading.Tasks;
using MVVMProject.Interfaces;

namespace MVVMProject.Services
{
    public class MessageService: IMessageService
    {
        public async Task ShowAsync(string title, string message, string cancel)
        {
            await App.Current.MainPage.DisplayAlert(title, message, cancel);
        }
    }
}
