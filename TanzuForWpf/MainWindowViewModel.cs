using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Tanzu.Tools.ViewModels;
using Tanzu.Tools.WpfViews;

namespace TanzuForWpf
{
    public class MainWindowViewModel : AbstractViewModel, IMainWindowViewModel
    {
        public MainWindowViewModel(IServiceProvider services)
            : base(services)
        {
        }

        public bool CanOpenCloudExplorer(object arg)
        {
            return true;
        }

        public void OpenCloudExplorer(object arg)
        {
            ActiveView = ViewLocatorService.NavigateTo(typeof(CloudExplorerViewModel).Name);
        }
    }
}
