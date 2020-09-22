using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using Tanzu.Tools.Services.CloudFoundry;
using Tanzu.Tools.Services.Dialog;
using Tanzu.Tools.Services.Locator;

namespace Tanzu.Tools.ViewModels
{
    [TestClass]
    public class AbstractViewModelTests : ViewModelTestSupport
    {
        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void Constructor_Initializes()
        {
            var vm = new TestAbstractViewModel(services);
            Assert.AreSame(services, vm.Services);
            Assert.IsNotNull(vm.DialogService);
            Assert.IsNotNull(vm.ViewLocatorService);
            Assert.IsNotNull(vm.CloudFoundryService);
            Assert.IsFalse(vm.IsLoggedIn);
            Assert.IsNull(vm.ActiveView);
        }
    }

    class TestAbstractViewModel : AbstractViewModel
    {
        public TestAbstractViewModel(IServiceProvider services) : base(services)
        {
        }
    }
}
