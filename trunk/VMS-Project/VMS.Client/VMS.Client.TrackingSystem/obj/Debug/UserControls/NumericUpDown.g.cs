﻿#pragma checksum "..\..\..\UserControls\NumericUpDown.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "35674421714D31164A433F0AD55D9669"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace VMS.Client.TrackingSystem.UserControls {
    
    
    /// <summary>
    /// NumericUpDown
    /// </summary>
    public partial class NumericUpDown : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\UserControls\NumericUpDown.xaml"
        internal VMS.Client.TrackingSystem.UserControls.NumericUpDown UserControl;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Controls.Border brdNumeriUpDown;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Controls.Grid grdNumeriUpDown;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Controls.TextBox txtNumericUpDown;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Controls.Button btnUp;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Shapes.Path Up;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Controls.Button btnDown;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\UserControls\NumericUpDown.xaml"
        internal System.Windows.Shapes.Path Down;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/VMS.Client.TrackingSystem;component/usercontrols/numericupdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\NumericUpDown.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.UserControl = ((VMS.Client.TrackingSystem.UserControls.NumericUpDown)(target));
            return;
            case 2:
            this.brdNumeriUpDown = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.grdNumeriUpDown = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.txtNumericUpDown = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnUp = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Up = ((System.Windows.Shapes.Path)(target));
            return;
            case 7:
            this.btnDown = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.Down = ((System.Windows.Shapes.Path)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}