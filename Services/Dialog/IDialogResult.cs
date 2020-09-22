using System;
using System.Collections.Generic;
using System.Text;

namespace Tanzu.Tools.Services.Dialog
{
    public interface IDialogResult
    {
        bool? Result { get; }
    }
}
