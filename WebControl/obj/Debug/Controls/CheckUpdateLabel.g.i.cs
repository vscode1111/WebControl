﻿#pragma checksum "D:\Мои документы\!Projects\RapidInterface\RapidInterface\WebControl\WebControl\Controls\CheckUpdateLabel.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AE6AED6DFAD286047A71821FD17ED1E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
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


namespace WebControl {
    
    
    public partial class CheckUpdateLabel : System.Windows.Controls.UserControl {
        
        internal System.Windows.Media.Animation.Storyboard StoryboardUnchecked;
        
        internal System.Windows.VisualStateGroup VisualStateGroup;
        
        internal System.Windows.VisualState ControlChecked;
        
        internal System.Windows.VisualState ControlUnchecked;
        
        internal System.Windows.Shapes.Path path;
        
        internal System.Windows.Controls.Grid grid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebControl;component/Controls/CheckUpdateLabel.xaml", System.UriKind.Relative));
            this.StoryboardUnchecked = ((System.Windows.Media.Animation.Storyboard)(this.FindName("StoryboardUnchecked")));
            this.VisualStateGroup = ((System.Windows.VisualStateGroup)(this.FindName("VisualStateGroup")));
            this.ControlChecked = ((System.Windows.VisualState)(this.FindName("ControlChecked")));
            this.ControlUnchecked = ((System.Windows.VisualState)(this.FindName("ControlUnchecked")));
            this.path = ((System.Windows.Shapes.Path)(this.FindName("path")));
            this.grid = ((System.Windows.Controls.Grid)(this.FindName("grid")));
        }
    }
}
