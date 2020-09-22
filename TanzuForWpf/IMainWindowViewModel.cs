using Tanzu.Tools.ViewModels;

namespace TanzuForWpf
{
    public interface IMainWindowViewModel : IViewModel
    {
        bool CanOpenCloudExplorer(object arg);
        void OpenCloudExplorer(object arg);
    }
}
