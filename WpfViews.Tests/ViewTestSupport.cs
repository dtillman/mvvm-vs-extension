using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tanzu.Tools.Services.CloudFoundry;
using Tanzu.Tools.Services.Dialog;
using Tanzu.Tools.Services.Locator;

namespace Tanzu.Tools.WpfViews.Tests
{
     public abstract class ViewTestSupport
    {
        protected IServiceProvider services;

        protected Mock<ICloudFoundryService> mockCloudFoundryService;
        protected Mock<IDialogService> mockDialogService;
        protected Mock<IViewLocatorService> mockViewLocatorService;

        protected ViewTestSupport()
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
