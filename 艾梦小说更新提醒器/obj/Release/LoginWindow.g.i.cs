﻿#pragma checksum "..\..\LoginWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5A1397E45528AE5E1EC1573A08DF274C"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using MyWindow;
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
using 小说更新提醒器.controls;


namespace 艾梦小说更新提醒器 {
    
    
    /// <summary>
    /// LoginWindow
    /// </summary>
    public partial class LoginWindow : MyWindow.WindowBase, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserCode;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pwd;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_login_Copy;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_regist;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SavePwd;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\LoginWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal 小说更新提醒器.controls.LoadingWait _loading;
        
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
            System.Uri resourceLocater = new System.Uri("/艾梦小说更新提醒器;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LoginWindow.xaml"
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
            this.UserCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Pwd = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.btn_login = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\LoginWindow.xaml"
            this.btn_login.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_login_MouseEnter);
            
            #line default
            #line hidden
            
            #line 45 "..\..\LoginWindow.xaml"
            this.btn_login.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_login_MouseLeave);
            
            #line default
            #line hidden
            
            #line 45 "..\..\LoginWindow.xaml"
            this.btn_login.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_login_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\LoginWindow.xaml"
            this.btn_login_Copy.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_login_MouseEnter);
            
            #line default
            #line hidden
            
            #line 58 "..\..\LoginWindow.xaml"
            this.btn_login_Copy.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_login_MouseLeave);
            
            #line default
            #line hidden
            
            #line 58 "..\..\LoginWindow.xaml"
            this.btn_login_Copy.Click += new System.Windows.RoutedEventHandler(this.btn_login_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_regist = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\LoginWindow.xaml"
            this.btn_regist.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_login_MouseEnter);
            
            #line default
            #line hidden
            
            #line 73 "..\..\LoginWindow.xaml"
            this.btn_regist.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_login_MouseLeave);
            
            #line default
            #line hidden
            
            #line 73 "..\..\LoginWindow.xaml"
            this.btn_regist.Click += new System.Windows.RoutedEventHandler(this.btn_regist_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SavePwd = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this._loading = ((小说更新提醒器.controls.LoadingWait)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

