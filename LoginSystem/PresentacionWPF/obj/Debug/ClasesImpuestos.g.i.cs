﻿#pragma checksum "..\..\ClasesImpuestos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75F76BA43E826E12D9776809917A1762184E949CE3E85AB687700A9CB8F8CCEA"
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
    /// ClasesImpuestos
    /// </summary>
    public partial class ClasesImpuestos : Vista.Document, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 13 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgClasesImpuestos;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn codigo;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn name;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn tasa;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn salestax;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTemplateColumn purchtax;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\ClasesImpuestos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/Vista;component/clasesimpuestos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClasesImpuestos.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 10 "..\..\ClasesImpuestos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.ExitCommand_CanExecute);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ClasesImpuestos.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExitCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dgClasesImpuestos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 13 "..\..\ClasesImpuestos.xaml"
            this.dgClasesImpuestos.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.dgClasesImpuestos_BeginningEdit);
            
            #line default
            #line hidden
            return;
            case 3:
            this.codigo = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 4:
            this.name = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 5:
            this.tasa = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 6:
            this.salestax = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 8:
            this.purchtax = ((System.Windows.Controls.DataGridTemplateColumn)(target));
            return;
            case 10:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 162 "..\..\ClasesImpuestos.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.btnOk_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 163 "..\..\ClasesImpuestos.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnWindow_Close);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 7:
            
            #line 122 "..\..\ClasesImpuestos.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.img_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 143 "..\..\ClasesImpuestos.xaml"
            ((System.Windows.Controls.Image)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.imgPuchTax_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

