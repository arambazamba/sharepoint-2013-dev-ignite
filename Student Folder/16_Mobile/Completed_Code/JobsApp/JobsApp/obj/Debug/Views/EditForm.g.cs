﻿#pragma checksum "c:\devprojects\JobsApp\JobsApp\Views\EditForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "064B04BF495E5CECC0EB6EA8DE5C4C78"
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
    
    
    public partial class EditForm : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage EditPage;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.ProgressBar progressBar;
        
        internal System.Windows.Controls.TextBox txtTitle;
        
        internal System.Windows.Controls.TextBox txtDescription;
        
        internal System.Windows.Controls.TextBox txtAssignedTo;
        
        internal System.Windows.Controls.ListBox lstBoxAttachments;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnSubmit;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnCancel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/JobsApp;component/Views/EditForm.xaml", System.UriKind.Relative));
            this.EditPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("EditPage")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.progressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("progressBar")));
            this.txtTitle = ((System.Windows.Controls.TextBox)(this.FindName("txtTitle")));
            this.txtDescription = ((System.Windows.Controls.TextBox)(this.FindName("txtDescription")));
            this.txtAssignedTo = ((System.Windows.Controls.TextBox)(this.FindName("txtAssignedTo")));
            this.lstBoxAttachments = ((System.Windows.Controls.ListBox)(this.FindName("lstBoxAttachments")));
            this.btnSubmit = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnSubmit")));
            this.btnCancel = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnCancel")));
        }
    }
}

