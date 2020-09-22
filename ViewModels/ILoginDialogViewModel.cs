using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Tanzu.Tools.ViewModels
{
    public interface ILoginDialogViewModel : IViewModel
    {
        string Target { get; set; }
        string Username { get; set; }
        string HttpProxy { get; set; }
        bool SkipSsl { get; set; }
        bool HasErrors { get; set; }
        string ErrorMessage { get; set; }
        Func<SecureString> GetPassword { get; set; }
        Task ConnectToCloudFoundry(object arg);
        bool CanConnectToCloudFoundry(object arg);
    }
}
