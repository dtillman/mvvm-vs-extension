using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Tanzu.Tools.Services.CloudFoundry;
using Tanzu.Tools.Services.Dialog;
using Tanzu.Tools.Services.Locator;
using Tanzu.Tools.ViewModels;

namespace Tanzu.Tools.ViewModels
{
    [TestClass]
    public class CloudExplorerViewModelTests : ViewModelTestSupport
    {


        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void CanOpenLoginView_ReturnsExcpected()
        {
            var vm = new CloudExplorerViewModel(services);
            Assert.IsTrue(vm.CanOpenLoginView(null));
        }

        [TestMethod]
        public void OpenLoginView_CallsDialogService_ShowDialog()
        {
            var vm = new CloudExplorerViewModel(services);
            vm.OpenLoginView(null);
            mockDialogService.Verify(ds => ds.ShowDialog(typeof(LoginDialogViewModel).Name, null), Times.Once);
        }
    }
}
