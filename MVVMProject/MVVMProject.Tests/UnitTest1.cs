using System;
using FakeItEasy;
using MVVMProject.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Essentials;
using Xunit;
using Xamarin.Essentials.Interfaces;
using Moq;

namespace MVVMProject.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            var versionTracking = new Mock<IVersionTracking>();
            var platformServicesFake = A.Fake<IPlatformServices>();
            Device.PlatformServices = platformServicesFake;
        }

        [Fact]
        public void Silder_Is_Disababled_When_Entery_Is_Empty()
        {
            // Note:
            // Not compeleted all the way, but this was an opportunity
            // to explore unit testing
            var rotateViewModel = new RotateViewModel();
            var isEnabled = rotateViewModel.IsEnabled;
            Assert.False(isEnabled);
        }
    }
}
