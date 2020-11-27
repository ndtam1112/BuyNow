﻿#pragma checksum "..\..\Account.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D0DB1CBF43FFFE30444C3B2CE30D376F16C4BBC4D8FE2BDB22D1F458D1B71C3C"
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
using View;


namespace View {
    
    
    /// <summary>
    /// Account
    /// </summary>
    public partial class Account : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Ten_Nguoi_Dung;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMinimize;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCategory;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 199 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 209 "..\..\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMe;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/account.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Account.xaml"
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
            
            #line 18 "..\..\Account.xaml"
            ((View.Account)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Ten_Nguoi_Dung = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\Account.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnMinimize = ((System.Windows.Controls.Button)(target));
            
            #line 144 "..\..\Account.xaml"
            this.btnMinimize.Click += new System.Windows.RoutedEventHandler(this.btnMinimized_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCategory = ((System.Windows.Controls.Button)(target));
            
            #line 181 "..\..\Account.xaml"
            this.btnCategory.Click += new System.Windows.RoutedEventHandler(this.btnCategory_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 190 "..\..\Account.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 200 "..\..\Account.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.btnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnMe = ((System.Windows.Controls.Button)(target));
            
            #line 210 "..\..\Account.xaml"
            this.btnMe.Click += new System.Windows.RoutedEventHandler(this.btnMe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

