﻿#pragma checksum "D:\_Projects\WebControl\WebControl\Controls\HMIRectangleEx.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA806D77B2BE85AB9D1F426C06018EF1"
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
    
    
    public partial class HMIRectangleEx : WebControl.HMIBooleanBase {
        
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
        
        internal System.Windows.Shapes.Rectangle recBase;
        
        internal System.Windows.Controls.TextBlock tbCaptionAdditional;
        
        internal System.Windows.Controls.TextBlock tbCaptionMain;
        
        internal System.Windows.Controls.TextBlock tbUnknown;
        
        internal System.Windows.Controls.Viewbox vwWarning;
        
        internal System.Windows.Shapes.Rectangle recMouse;
        
        internal System.Windows.Controls.Grid grpCamera;
        
        internal System.Windows.Shapes.Path path2;
        
        internal System.Windows.Shapes.Path path3;
        
        internal System.Windows.Controls.Grid grpComputer;
        
        internal System.Windows.Shapes.Path path1;
        
        internal System.Windows.Shapes.Path path4;
        
        internal System.Windows.Controls.Grid grpRegistrator;
        
        internal System.Windows.Shapes.Path path5;
        
        internal System.Windows.Shapes.Path path6;
        
        internal System.Windows.Controls.Viewbox grpRegistratorDB;
        
        internal System.Windows.Controls.Viewbox grpDatabase;
        
        internal System.Windows.Controls.Grid grpMonitor;
        
        internal System.Windows.Shapes.Path path7;
        
        internal System.Windows.Shapes.Path path8;
        
        internal System.Windows.Shapes.Path pathExternalLink;
        
        internal System.Windows.Controls.Grid grpServer;
        
        internal System.Windows.Shapes.Path path9;
        
        internal System.Windows.Shapes.Path path9_Copy;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Controls/HMIRectangleEx.xaml", System.UriKind.Relative));
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
            this.recBase = ((System.Windows.Shapes.Rectangle)(this.FindName("recBase")));
            this.tbCaptionAdditional = ((System.Windows.Controls.TextBlock)(this.FindName("tbCaptionAdditional")));
            this.tbCaptionMain = ((System.Windows.Controls.TextBlock)(this.FindName("tbCaptionMain")));
            this.tbUnknown = ((System.Windows.Controls.TextBlock)(this.FindName("tbUnknown")));
            this.vwWarning = ((System.Windows.Controls.Viewbox)(this.FindName("vwWarning")));
            this.recMouse = ((System.Windows.Shapes.Rectangle)(this.FindName("recMouse")));
            this.grpCamera = ((System.Windows.Controls.Grid)(this.FindName("grpCamera")));
            this.path2 = ((System.Windows.Shapes.Path)(this.FindName("path2")));
            this.path3 = ((System.Windows.Shapes.Path)(this.FindName("path3")));
            this.grpComputer = ((System.Windows.Controls.Grid)(this.FindName("grpComputer")));
            this.path1 = ((System.Windows.Shapes.Path)(this.FindName("path1")));
            this.path4 = ((System.Windows.Shapes.Path)(this.FindName("path4")));
            this.grpRegistrator = ((System.Windows.Controls.Grid)(this.FindName("grpRegistrator")));
            this.path5 = ((System.Windows.Shapes.Path)(this.FindName("path5")));
            this.path6 = ((System.Windows.Shapes.Path)(this.FindName("path6")));
            this.grpRegistratorDB = ((System.Windows.Controls.Viewbox)(this.FindName("grpRegistratorDB")));
            this.grpDatabase = ((System.Windows.Controls.Viewbox)(this.FindName("grpDatabase")));
            this.grpMonitor = ((System.Windows.Controls.Grid)(this.FindName("grpMonitor")));
            this.path7 = ((System.Windows.Shapes.Path)(this.FindName("path7")));
            this.path8 = ((System.Windows.Shapes.Path)(this.FindName("path8")));
            this.pathExternalLink = ((System.Windows.Shapes.Path)(this.FindName("pathExternalLink")));
            this.grpServer = ((System.Windows.Controls.Grid)(this.FindName("grpServer")));
            this.path9 = ((System.Windows.Shapes.Path)(this.FindName("path9")));
            this.path9_Copy = ((System.Windows.Shapes.Path)(this.FindName("path9_Copy")));
        }
    }
}

