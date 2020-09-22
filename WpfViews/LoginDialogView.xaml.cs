using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Tanzu.Tools.ViewModels;
using Tanzu.Tools.WpfViews.Commands;

namespace Tanzu.Tools.WpfViews
{
    /// <summary>
    /// Interaction logic for LoginDialogView.xaml
    /// </summary>
    public partial class LoginDialogView : Window, ILoginDialogView
    {
        public LoginDialogView()
        {
            InitializeComponent();

        }

        public LoginDialogView(ILoginDialogViewModel viewModel)
        {
            LoginCommand = new AsyncDelegatingCommand(viewModel.ConnectToCloudFoundry, viewModel.CanConnectToCloudFoundry);
            viewModel.GetPassword = GetPassword;
            DataContext = viewModel;
            InitializeComponent();
        }

        public SecureString GetPassword()
        {
            return pbPassword.SecurePassword;
        }

        public ICommand LoginCommand { get; }
    }
}
