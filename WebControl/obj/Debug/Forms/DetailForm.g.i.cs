﻿#pragma checksum "E:\WebControl\WebControl\Forms\DetailForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0C83CCB8474486EE1E232279B078130C"
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
    
    
    public partial class DetailForm : WebControl.UserControlEx {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock teDescription;
        
        internal System.Windows.Controls.TextBlock teDataName;
        
        internal System.Windows.Controls.TextBlock teUnit;
        
        internal System.Windows.Controls.TextBlock teDataType;
        
        internal System.Windows.Controls.TextBlock teFormatValue;
        
        internal System.Windows.Controls.TextBlock teMinValue;
        
        internal System.Windows.Controls.TextBlock teMaxValue;
        
        internal System.Windows.Controls.TextBlock teTimeOut;
        
        internal System.Windows.Controls.TextBlock teDataValue;
        
        internal System.Windows.Controls.TextBlock teQuality;
        
        internal System.Windows.Controls.TextBlock teDeviceTime;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Forms/DetailForm.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.teDescription = ((System.Windows.Controls.TextBlock)(this.FindName("teDescription")));
            this.teDataName = ((System.Windows.Controls.TextBlock)(this.FindName("teDataName")));
            this.teUnit = ((System.Windows.Controls.TextBlock)(this.FindName("teUnit")));
            this.teDataType = ((System.Windows.Controls.TextBlock)(this.FindName("teDataType")));
            this.teFormatValue = ((System.Windows.Controls.TextBlock)(this.FindName("teFormatValue")));
            this.teMinValue = ((System.Windows.Controls.TextBlock)(this.FindName("teMinValue")));
            this.teMaxValue = ((System.Windows.Controls.TextBlock)(this.FindName("teMaxValue")));
            this.teTimeOut = ((System.Windows.Controls.TextBlock)(this.FindName("teTimeOut")));
            this.teDataValue = ((System.Windows.Controls.TextBlock)(this.FindName("teDataValue")));
            this.teQuality = ((System.Windows.Controls.TextBlock)(this.FindName("teQuality")));
            this.teDeviceTime = ((System.Windows.Controls.TextBlock)(this.FindName("teDeviceTime")));
            this.teSqlTime = ((System.Windows.Controls.TextBlock)(this.FindName("teSqlTime")));
        }
    }
}

