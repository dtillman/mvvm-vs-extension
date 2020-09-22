using System.Windows.Controls;
using System.Windows.Input;
using Tanzu.Tools.ViewModels;
using Tanzu.Tools.WpfViews.Commands;

namespace Tanzu.Tools.WpfViews
{
    /// <summary>
    /// Interaction logic for CloudExplorerView.xaml
    /// </summary>
    public partial class CloudExplorerView : UserControl, ICloudExplorerView
    {
        public CloudExplorerView()
        {
            InitializeComponent();
        }

        public CloudExplorerView(ICloudExplorerViewModel viewModel)
        {
            OpenLoginFormCommand = new DelegatingCommand(viewModel.OpenLoginView, viewModel.CanOpenLoginView);
            DataContext = viewModel;
            InitializeComponent();
        }

        public ICommand OpenLoginFormCommand { get; }
    }
}
