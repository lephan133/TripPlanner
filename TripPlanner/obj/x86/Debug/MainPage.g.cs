﻿#pragma checksum "E:\TripPlanner\TripPlanner\TripPlanner\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E7BB283B0290C28436A68C7913718E3E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripPlanner
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.mySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.menuItems = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 29 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.menuItems).SelectionChanged += this.menuItems_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.hamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.hamburgerButton).Click += this.hamburgerButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.addNewPlan = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 64 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.addNewPlan).Click += this.addNewPlan_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.selectPlan = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 70 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.selectPlan).Click += this.selectPlan_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.deletePlan = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 76 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.deletePlan).Click += this.deletePlan_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.editPlan = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 82 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.editPlan).Click += this.deletePlan_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.cancelPlan = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 87 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.cancelPlan).Click += this.cancelPlan_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

