﻿#pragma checksum "..\..\..\User Control\ProductDetail.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6F918F061FDE2EBEE02BFA27CD37929C94BF2CDDDD53E5FFB3CCA80FE41F1693"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using View.User_Control;


namespace View.User_Control {
    
    
    /// <summary>
    /// ProductDetail
    /// </summary>
    public partial class ProductDetail : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal View.User_Control.ProductDetail productDetail;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSize;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinus;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbNumOfPro;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlus;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbPrice;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\User Control\ProductDetail.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddToHistory;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/user%20control/productdetail.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User Control\ProductDetail.xaml"
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
            this.productDetail = ((View.User_Control.ProductDetail)(target));
            return;
            case 2:
            this.cbSize = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.btnMinus = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.tbNumOfPro = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.btnPlus = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.tbPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnAddToHistory = ((System.Windows.Controls.Button)(target));
            
            #line 116 "..\..\..\User Control\ProductDetail.xaml"
            this.btnAddToHistory.Click += new System.Windows.RoutedEventHandler(this.btnAddToHistory_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

