﻿#pragma checksum "D:\Мои документы\!Projects\WebControl\WebControl\Forms\TrendForm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BEE9649D321130BE9C5A089EDBA1D0F3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AmCharts.Windows.QuickCharts;
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
    
    
    public partial class TrendForm : WebControl.UserControlEx {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal WebControl.ButtonEx btnStartPause;
        
        internal DevExpress.Xpf.Editors.ComboBoxEdit cbeTimeDistance;
        
        internal System.Windows.Controls.TextBlock tbToolTipTimeDistace;
        
        internal DevExpress.Xpf.Editors.DateEdit deBegin;
        
        internal DevExpress.Xpf.Editors.DateEdit deEnd;
        
        internal WebControl.ButtonEx btnTimePeriodAuto;
        
        internal DevExpress.Xpf.Editors.ComboBoxEdit cbeTimePeriod;
        
        internal System.Windows.Controls.TextBlock tbToolTipTimePeriod;
        
        internal WebControl.ButtonEx btnUpdate;
        
        internal WebControl.ButtonEx btnBack;
        
        internal WebControl.ButtonEx btnForward;
        
        internal WebControl.ButtonEx btnExport;
        
        internal AmCharts.Windows.QuickCharts.SerialChart chrBase;
        
        internal System.Windows.Controls.TextBlock lblStatus;
        
        internal WebControl.CheckUpdateLabel ckUpdate;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Forms/TrendForm.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnStartPause = ((WebControl.ButtonEx)(this.FindName("btnStartPause")));
            this.cbeTimeDistance = ((DevExpress.Xpf.Editors.ComboBoxEdit)(this.FindName("cbeTimeDistance")));
            this.tbToolTipTimeDistace = ((System.Windows.Controls.TextBlock)(this.FindName("tbToolTipTimeDistace")));
            this.deBegin = ((DevExpress.Xpf.Editors.DateEdit)(this.FindName("deBegin")));
            this.deEnd = ((DevExpress.Xpf.Editors.DateEdit)(this.FindName("deEnd")));
            this.btnTimePeriodAuto = ((WebControl.ButtonEx)(this.FindName("btnTimePeriodAuto")));
            this.cbeTimePeriod = ((DevExpress.Xpf.Editors.ComboBoxEdit)(this.FindName("cbeTimePeriod")));
            this.tbToolTipTimePeriod = ((System.Windows.Controls.TextBlock)(this.FindName("tbToolTipTimePeriod")));
            this.btnUpdate = ((WebControl.ButtonEx)(this.FindName("btnUpdate")));
            this.btnBack = ((WebControl.ButtonEx)(this.FindName("btnBack")));
            this.btnForward = ((WebControl.ButtonEx)(this.FindName("btnForward")));
            this.btnExport = ((WebControl.ButtonEx)(this.FindName("btnExport")));
            this.chrBase = ((AmCharts.Windows.QuickCharts.SerialChart)(this.FindName("chrBase")));
            this.lblStatus = ((System.Windows.Controls.TextBlock)(this.FindName("lblStatus")));
            this.ckUpdate = ((WebControl.CheckUpdateLabel)(this.FindName("ckUpdate")));
        }
    }
}
