using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.Services.CloudFoundry
{
    public class ConnectResult
    {
        public ConnectResult(bool loggedIn, string errorMessage)
        {
            IsLoggedIn = loggedIn;
            ErrorMessage = errorMessage;
        }
        
        public bool IsLoggedIn { get; }
        public string ErrorMessage { get; }
    }
}
