﻿#pragma checksum "..\..\..\User Control\Account.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D7A9586B3CFB4C7CAFC84A03F5577FB54F14777CFAA003175E0345F2BAD58C3B"
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
    /// Account
    /// </summary>
    public partial class Account : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal View.User_Control.Account account;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement movieLoader;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Phone_clientt;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Name_clientt;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Address_clientt;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveInfor;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock passwordold;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password1;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox password2;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\User Control\Account.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangePass;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/user%20control/account.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\User Control\Account.xaml"
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
            this.account = ((View.User_Control.Account)(target));
            return;
            case 2:
            this.movieLoader = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 3:
            this.Phone_clientt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Name_clientt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Address_clientt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.saveInfor = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\User Control\Account.xaml"
            this.saveInfor.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.passwordold = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.password1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 9:
            this.password2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 10:
            this.btnChangePass = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\User Control\Account.xaml"
            this.btnChangePass.Click += new System.Windows.RoutedEventHandler(this.btnChangePass_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

