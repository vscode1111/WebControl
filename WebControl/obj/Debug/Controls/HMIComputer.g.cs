﻿#pragma checksum "D:\_Projects\WebControl\WebControl\Controls\HMIComputer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E45EF64B6FE260C3B3B57E630E07E840"
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
    
    
    public partial class HMIComputer : WebControl.HMIBooleanBase {
        
        internal System.Windows.Controls.TextBlock tbToolTip;
        
        internal System.Windows.VisualStateGroup MouseStateGroup;
        
        internal System.Windows.VisualState ControlMouseEnter;
        
        internal System.Windows.VisualState ControlMouseLeave;
        
        internal System.Windows.VisualStateGroup ValueStateGroup;
        
        internal System.Windows.VisualState ControlValueON;
        
        internal System.Windows.VisualState ControlValueOFF;
        
        internal System.Windows.VisualState ControlValueUnknown;
        
        internal System.Windows.VisualStateGroup ActualStateGroup;
        
        internal System.Windows.VisualState ControlActualTrue;
        
        internal System.Windows.VisualState ControlActualFalse;
        
        internal System.Windows.Shapes.Rectangle recBase2;
        
        internal System.Windows.Shapes.Rectangle recBase;
        
        internal System.Windows.Controls.TextBlock tbUnknown;
        
        internal System.Windows.Shapes.Path pathPase3;
        
        internal System.Windows.Controls.Viewbox vwWarning;
        
        internal System.Windows.Shapes.Rectangle recMouse;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Controls/HMIComputer.xaml", System.UriKind.Relative));
            this.tbToolTip = ((System.Windows.Controls.TextBlock)(this.FindName("tbToolTip")));
            this.MouseStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("MouseStateGroup")));
            this.ControlMouseEnter = ((System.Windows.VisualState)(this.FindName("ControlMouseEnter")));
            this.ControlMouseLeave = ((System.Windows.VisualState)(this.FindName("ControlMouseLeave")));
            this.ValueStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("ValueStateGroup")));
            this.ControlValueON = ((System.Windows.VisualState)(this.FindName("ControlValueON")));
            this.ControlValueOFF = ((System.Windows.VisualState)(this.FindName("ControlValueOFF")));
            this.ControlValueUnknown = ((System.Windows.VisualState)(this.FindName("ControlValueUnknown")));
            this.ActualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("ActualStateGroup")));
            this.ControlActualTrue = ((System.Windows.VisualState)(this.FindName("ControlActualTrue")));
            this.ControlActualFalse = ((System.Windows.VisualState)(this.FindName("ControlActualFalse")));
            this.recBase2 = ((System.Windows.Shapes.Rectangle)(this.FindName("recBase2")));
            this.recBase = ((System.Windows.Shapes.Rectangle)(this.FindName("recBase")));
            this.tbUnknown = ((System.Windows.Controls.TextBlock)(this.FindName("tbUnknown")));
            this.pathPase3 = ((System.Windows.Shapes.Path)(this.FindName("pathPase3")));
            this.vwWarning = ((System.Windows.Controls.Viewbox)(this.FindName("vwWarning")));
            this.recMouse = ((System.Windows.Shapes.Rectangle)(this.FindName("recMouse")));
        }
    }
}

