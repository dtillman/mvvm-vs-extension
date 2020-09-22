using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.Services.Locator
{
    public interface IViewLocatorService
    {
        string CurrentView { get; }
        object NavigateTo(string viewModelName, object parameter = null);
    }
}
