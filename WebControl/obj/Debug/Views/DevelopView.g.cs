﻿#pragma checksum "D:\Мои документы\!Projects\WebControl\WebControl\Views\DevelopView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "39DECB8A0A7BA8F389D77778F17A0288"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18063
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
    
    
    public partial class DevelopView : WebControl.ViewBase {
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.Controls.Label teLastUpdateTime;
        
        internal System.Windows.Controls.Label teServerClientTimeDiff;
        
        internal System.Windows.Controls.Label teTimeZoneDiff;
        
        internal System.Windows.Controls.Label teFirst;
        
        internal System.Windows.Controls.Label teError;
        
        internal System.Windows.Controls.Label teServerTime;
        
        internal System.Windows.Controls.Label teItemCount;
        
        internal System.Windows.Controls.Label teLoadTime;
        
        internal System.Windows.Controls.HyperlinkButton teServiceAddress;
        
        internal System.Windows.Controls.Label teVersion;
        
        internal System.Windows.Controls.Label teServerIPAddress;
        
        internal System.Windows.Controls.Label teClientIPAddress;
        
        internal System.Windows.Controls.Label teClientGetClientGUID;
        
        internal System.Windows.Controls.Label teClientBrowserInformation;
        
        internal System.Windows.Controls.Label teGUI;
        
        internal System.Windows.Controls.Label teServiceInfo;
        
        internal System.Windows.Controls.Label teServerItemUpdateSync;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Views/DevelopView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.teLastUpdateTime = ((System.Windows.Controls.Label)(this.FindName("teLastUpdateTime")));
            this.teServerClientTimeDiff = ((System.Windows.Controls.Label)(this.FindName("teServerClientTimeDiff")));
            this.teTimeZoneDiff = ((System.Windows.Controls.Label)(this.FindName("teTimeZoneDiff")));
            this.teFirst = ((System.Windows.Controls.Label)(this.FindName("teFirst")));
            this.teError = ((System.Windows.Controls.Label)(this.FindName("teError")));
            this.teServerTime = ((System.Windows.Controls.Label)(this.FindName("teServerTime")));
            this.teItemCount = ((System.Windows.Controls.Label)(this.FindName("teItemCount")));
            this.teLoadTime = ((System.Windows.Controls.Label)(this.FindName("teLoadTime")));
            this.teServiceAddress = ((System.Windows.Controls.HyperlinkButton)(this.FindName("teServiceAddress")));
            this.teVersion = ((System.Windows.Controls.Label)(this.FindName("teVersion")));
            this.teServerIPAddress = ((System.Windows.Controls.Label)(this.FindName("teServerIPAddress")));
            this.teClientIPAddress = ((System.Windows.Controls.Label)(this.FindName("teClientIPAddress")));
            this.teClientGetClientGUID = ((System.Windows.Controls.Label)(this.FindName("teClientGetClientGUID")));
            this.teClientBrowserInformation = ((System.Windows.Controls.Label)(this.FindName("teClientBrowserInformation")));
            this.teGUI = ((System.Windows.Controls.Label)(this.FindName("teGUI")));
            this.teServiceInfo = ((System.Windows.Controls.Label)(this.FindName("teServiceInfo")));
            this.teServerItemUpdateSync = ((System.Windows.Controls.Label)(this.FindName("teServerItemUpdateSync")));
        }
    }
}

