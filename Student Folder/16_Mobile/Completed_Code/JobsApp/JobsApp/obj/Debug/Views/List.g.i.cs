﻿#pragma checksum "c:\devprojects\JobsApp\JobsApp\Views\List.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "794E368AD87191041886CACC8B77F6C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace JobsApp {
    
    
    public partial class ListForm : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage ListViewPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.Pivot Views;
        
        internal Microsoft.Phone.Controls.PivotItem View1;
        
        internal System.Windows.Controls.ListBox lstBox1;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnNew;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnRefresh;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnSettings;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/JobsApp;component/Views/List.xaml", System.UriKind.Relative));
            this.ListViewPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("ListViewPage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Views = ((Microsoft.Phone.Controls.Pivot)(this.FindName("Views")));
            this.View1 = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("View1")));
            this.lstBox1 = ((System.Windows.Controls.ListBox)(this.FindName("lstBox1")));
            this.btnNew = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnNew")));
            this.btnRefresh = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnRefresh")));
            this.btnSettings = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnSettings")));
        }
    }
}

