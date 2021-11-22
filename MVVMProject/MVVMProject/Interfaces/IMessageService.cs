using System;
using System.Threading.Tasks;

namespace MVVMProject.Interfaces
{
    public interface IMessageService
    {
        Task ShowAsync(string title, string message, string cancel);
    }
}
