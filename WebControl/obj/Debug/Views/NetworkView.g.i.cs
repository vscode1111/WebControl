﻿#pragma checksum "D:\_Projects\WebControl\WebControl\Views\NetworkView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "16569B49081168EB9759BC5E81358C21"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WebControl;


namespace WebControl {
    
    
    public partial class NetworkView : WebControl.ViewBase {
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal WebControl.HMILabel test1;
        
        internal System.Windows.Controls.TextBlock teSqlTime;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Views/NetworkView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.test1 = ((WebControl.HMILabel)(this.FindName("test1")));
            this.teSqlTime = ((System.Windows.Controls.TextBlock)(this.FindName("teSqlTime")));
        }
    }
}

