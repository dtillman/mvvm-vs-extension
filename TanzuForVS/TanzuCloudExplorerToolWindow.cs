﻿namespace TanzuForVS
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;
    using Tanzu.Tools.WpfViews;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("051b6546-acb2-4f74-85b3-60de9fefab24")]
    public class TanzuCloudExplorerToolWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TanzuCloudExplorerToolWindow"/> class.
        /// </summary>
        public TanzuCloudExplorerToolWindow(ICloudExplorerView view) : base(null)
        {

            this.Caption = "Tanzu Cloud Explorer";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.

            this.Content = view;
        }
    }
}
