using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tanzu.Tools.WpfViews.Commands;

namespace TanzuForWpf
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window, IMainWindowView
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        public MainWindowView(IMainWindowViewModel viewModel)
        {
            OpenCloudExplorerCommand = new DelegatingCommand(viewModel.OpenCloudExplorer, viewModel.CanOpenCloudExplorer);
            DataContext = viewModel;
            InitializeComponent();
        }

        public ICommand OpenCloudExplorerCommand { get; }
    }
}
