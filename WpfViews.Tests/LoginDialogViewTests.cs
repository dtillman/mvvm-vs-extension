﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzu.Tools.ViewModels;
using Tanzu.Tools.WpfViews.Commands;

namespace Tanzu.Tools.WpfViews.Tests
{
    [TestClass]
    public class LoginDialogViewTests : ViewTestSupport
    {
        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void Constructor_Initializes()
        {
            var vm = new LoginDialogViewModel(services);
            vm.Target = "http://test/";
            var view = new LoginDialogView(vm);

            // Verify DataContext initalized
            Assert.AreSame(vm, view.DataContext);

            // Verify Login command points to view model
            var command = view.LoginCommand as AsyncDelegatingCommand;
            Assert.IsNotNull(command);
            Assert.AreEqual(vm, command.action.Target);

            // Verify ViewModel callback for password
            Assert.IsNotNull(vm.GetPassword);

            // Verify binding to Target to tbUrl
            Assert.AreEqual(vm.Target, view.tbUrl.Text);
        }
    }
}
