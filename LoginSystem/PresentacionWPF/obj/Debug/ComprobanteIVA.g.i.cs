﻿#pragma checksum "..\..\ComprobanteIVA.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B1701A6412F3DCBD003DED44C0D952ED2B817682DC324FC0857BEBB520912D78"
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
using System.Windows.Shell;
using Vista;


namespace Vista {
    
    
    /// <summary>
    /// ComprobanteIVA
    /// </summary>
    public partial class ComprobanteIVA : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ComprobanteIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblDesde;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ComprobanteIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDesde;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ComprobanteIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrear;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ComprobanteIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ComprobanteIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblHasta;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ComprobanteIVA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbHasta;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Vista;component/comprobanteiva.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ComprobanteIVA.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\ComprobanteIVA.xaml"
            ((Vista.ComprobanteIVA)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblDesde = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.cbDesde = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\ComprobanteIVA.xaml"
            this.cbDesde.LostFocus += new System.Windows.RoutedEventHandler(this.comboBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ComprobanteIVA.xaml"
            this.cbDesde.GotFocus += new System.Windows.RoutedEventHandler(this.comboBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCrear = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\ComprobanteIVA.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnWindow_Close);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lblHasta = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.cbHasta = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\ComprobanteIVA.xaml"
            this.cbHasta.LostFocus += new System.Windows.RoutedEventHandler(this.comboBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 17 "..\..\ComprobanteIVA.xaml"
            this.cbHasta.GotFocus += new System.Windows.RoutedEventHandler(this.comboBox_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

