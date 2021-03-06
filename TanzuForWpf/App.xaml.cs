﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using Tanzu.Tools.Services.CloudFoundry;
using Tanzu.Tools.Services.Dialog;
using Tanzu.Tools.Services.Locator;
using Tanzu.Tools.ViewModels;
using Tanzu.Tools.WpfViews;
using Tanzu.Tools.WpfViews.Services;

namespace TanzuForWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        //public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // var builder = new ConfigurationBuilder()
            // .SetBasePath(Directory.GetCurrentDirectory())
            // .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            // Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var window = ServiceProvider.GetRequiredService<IMainWindowView>() as Window;
            window?.Show();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICloudFoundryService, CloudFoundryService>();
            services.AddSingleton<IViewLocatorService, WpfViewLocatorService>();
            services.AddSingleton<IDialogService, WpfDialogService>();

            services.AddTransient<IMainWindowViewModel, MainWindowViewModel>();
            services.AddTransient<IMainWindowView, MainWindowView>();

            services.AddTransient<ICloudExplorerViewModel, CloudExplorerViewModel>();
            services.AddTransient<ICloudExplorerView, CloudExplorerView>();

            services.AddTransient<ILoginDialogViewModel, LoginDialogViewModel>();
            services.AddTransient<ILoginDialogView, LoginDialogView>();
        }
    }
}
