using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Tanzu.Tools.Services.CloudFoundry
{
    public class CloudFoundryService : ICloudFoundryService
    {
 

        public bool IsLoggedIn { get; set; } = false;

        public Task<ConnectResult> ConnectToCFAsync(string target, string username, SecureString password, string httpProxy, bool skipSsl)
        {
            if (string.IsNullOrEmpty(target))
            {
                throw new ArgumentException(nameof(target));
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException(nameof(username));
            }

            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            return Task.FromResult(new ConnectResult(false, string.Empty));

            //try
            //{
            //    Uri targetUri = new Uri(target);
            //    Uri httpProxyUri = null; // TODO: un-hardcode this later

            //    CloudCredentials credentials = new CloudCredentials();
            //    credentials.User = username;
            //    credentials.Password = password;

            //    IUAA cfApiV2Client = _cfApiClientFactory.CreateCfApiV2Client(targetUri, httpProxyUri, skipSsl);

            //    AuthenticationContext refreshToken = await cfApiV2Client.Login(credentials);
            //    WindowDataContext.IsLoggedIn = refreshToken.IsLoggedIn;
            //    if (refreshToken.IsLoggedIn) this.Close();
            //}
            //catch (Exception ex)
            //{
            //    var errorMessages = new List<string>();
            //    ErrorFormatter.FormatExceptionMessage(ex, errorMessages);
            //    WindowDataContext.ErrorMessage = string.Join(Environment.NewLine, errorMessages.ToArray());
            //    WindowDataContext.HasErrors = true;
            //}

        }
    }
}
