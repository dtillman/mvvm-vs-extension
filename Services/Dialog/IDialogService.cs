using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.Services.Dialog
{
    public interface IDialogService
    {
        IDialogResult ShowDialog(string dialogViewModel, object parameter = null);

        void CloseDialog(object dialogWindow, bool result);
    }
}
