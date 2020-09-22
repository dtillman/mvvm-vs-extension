using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.ViewModels
{
    public interface IViewModel
    {
        object ActiveView { get; set; }

        bool IsLoggedIn { get; set; }

    }
}
