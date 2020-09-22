using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Tanzu.Tools.Services.CloudFoundry;
using Tanzu.Tools.Services.Dialog;
using Tanzu.Tools.Services.Locator;

namespace Tanzu.Tools.ViewModels
{
    public abstract class ViewModelTestSupport
    {
        protected IServiceProvider services;

        protected Mock<ICloudFoundryService> mockCloudFoundryService;
        protected Mock<IDialogService> mockDialogService;
        protected Mock<IViewLocatorService> mockViewLocatorService;

        protected ViewModelTestSupport()
        {
            var services = new ServiceCollection();
            mockCloudFoundryService = new Mock<ICloudFoundryService>();
            mockDialogService = new Mock<IDialogService>();
            mockViewLocatorService = new Mock<IViewLocatorService>();

            services.AddSingleton<ICloudFoundryService>(mockCloudFoundryService.Object);
            services.AddSingleton<IDialogService>(mockDialogService.Object);
            services.AddSingleton<IViewLocatorService>(mockViewLocatorService.Object);
            this.services = services.BuildServiceProvider();
        }
    }
}
