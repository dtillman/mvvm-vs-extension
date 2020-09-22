using Microsoft.Extensions.DependencyInjection;
using System;
using System.ComponentModel;
using Tanzu.Tools.Services.CloudFoundry;
using Tanzu.Tools.Services.Dialog;
using Tanzu.Tools.Services.Locator;

namespace Tanzu.Tools.ViewModels
{
    public abstract class AbstractViewModel : IViewModel, INotifyPropertyChanged
    {
        private bool isLoggedIn;
        private object activeView;

        public event PropertyChangedEventHandler PropertyChanged;

        public AbstractViewModel(IServiceProvider services)
        {
            Services = services;
            CloudFoundryService = services.GetRequiredService<ICloudFoundryService>();
            DialogService = services.GetRequiredService<IDialogService>();
            ViewLocatorService = services.GetRequiredService<IViewLocatorService>();
            isLoggedIn = CloudFoundryService.IsLoggedIn;
        }

        public IServiceProvider Services { get; }

        public ICloudFoundryService CloudFoundryService { get; }

        public IViewLocatorService ViewLocatorService { get; }

        public IDialogService DialogService { get; }

        public object ActiveView
        {
            get
            {
                return this.activeView;
            }

            set
            {
                this.activeView = value;
                this.RaisePropertyChangedEvent("ActiveView");
            }
        }

        public bool IsLoggedIn
        {
            get => this.isLoggedIn;

            set
            {
                this.isLoggedIn = value;
                this.RaisePropertyChangedEvent("IsLoggedIn");
            }
        }

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
