﻿#pragma checksum "..\..\Admin_Dashboard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B70DEC054AA25E75A39AABB49E41CAD9B0F623F0A13223E1293C794490D7D1DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RAD;
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


namespace RAD {
    
    
    /// <summary>
    /// Admin_Dashboard
    /// </summary>
    public partial class Admin_Dashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Admin_Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_admin;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Admin_Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_medicalreport;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Admin_Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_patient;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Admin_Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Doctor;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Admin_Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_MedicalList;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Admin_Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_WaitingList;
        
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
            System.Uri resourceLocater = new System.Uri("/RAD;component/admin_dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin_Dashboard.xaml"
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
            this.btn_admin = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Admin_Dashboard.xaml"
            this.btn_admin.Click += new System.Windows.RoutedEventHandler(this.btn_admin_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btn_medicalreport = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Admin_Dashboard.xaml"
            this.btn_medicalreport.Click += new System.Windows.RoutedEventHandler(this.btn_medicalreport_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_patient = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\Admin_Dashboard.xaml"
            this.btn_patient.Click += new System.Windows.RoutedEventHandler(this.btn_patient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Doctor = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Admin_Dashboard.xaml"
            this.btn_Doctor.Click += new System.Windows.RoutedEventHandler(this.btn_Doctor_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btn_MedicalList = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Admin_Dashboard.xaml"
            this.btn_MedicalList.Click += new System.Windows.RoutedEventHandler(this.btn_MedicalList_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_WaitingList = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Admin_Dashboard.xaml"
            this.btn_WaitingList.Click += new System.Windows.RoutedEventHandler(this.btn_WaitingList_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
