using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.ViewModels
{
    public interface ICloudExplorerViewModel : IViewModel
    {
        bool CanOpenLoginView(object arg);

        void OpenLoginView(object arg);
    }
}
