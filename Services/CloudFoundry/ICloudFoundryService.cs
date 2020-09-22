using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Tanzu.Tools.Services.CloudFoundry
{
    public interface ICloudFoundryService
    {
        bool IsLoggedIn { get; }
        Task<ConnectResult> ConnectToCFAsync(string target, string username, SecureString password, string httpProxy, bool skipSsl);
    }
}
