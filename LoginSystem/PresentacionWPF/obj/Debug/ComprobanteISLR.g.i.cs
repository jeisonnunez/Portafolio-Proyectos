﻿#pragma checksum "..\..\ComprobanteISLR.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D033ACB9C271476E1F6206AF3EDB528B0AF97B0A80E0C8FCDC8CB16BECC8626D"
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
    /// ComprobanteISLR
    /// </summary>
    public partial class ComprobanteISLR : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblTipoTransaccion;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTipoTransaccion;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblProveedor;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtProveedor;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCrear;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblNroDocumento;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ComprobanteISLR.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNoDocumento;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/comprobanteislr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ComprobanteISLR.xaml"
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
            
            #line 8 "..\..\ComprobanteISLR.xaml"
            ((Vista.ComprobanteISLR)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTipoTransaccion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.cbTipoTransaccion = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\ComprobanteISLR.xaml"
            this.cbTipoTransaccion.LostFocus += new System.Windows.RoutedEventHandler(this.comboBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ComprobanteISLR.xaml"
            this.cbTipoTransaccion.GotFocus += new System.Windows.RoutedEventHandler(this.comboBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblProveedor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtProveedor = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\ComprobanteISLR.xaml"
            this.txtProveedor.LostFocus += new System.Windows.RoutedEventHandler(this.textBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 15 "..\..\ComprobanteISLR.xaml"
            this.txtProveedor.GotFocus += new System.Windows.RoutedEventHandler(this.textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCrear = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\ComprobanteISLR.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnWindow_Close);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lblNroDocumento = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.txtNoDocumento = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\ComprobanteISLR.xaml"
            this.txtNoDocumento.LostFocus += new System.Windows.RoutedEventHandler(this.textBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 26 "..\..\ComprobanteISLR.xaml"
            this.txtNoDocumento.GotFocus += new System.Windows.RoutedEventHandler(this.textBox_GotFocus);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
