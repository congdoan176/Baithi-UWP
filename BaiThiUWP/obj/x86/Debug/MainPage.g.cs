﻿#pragma checksum "C:\Users\admin\source\repos\BaiThiUWP\BaiThiUWP\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FE21146B6718875A0F53A08A712E7D51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaiThiUWP
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.AppBarToggleButton element2 = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)element2).Click += this.AppBarButton_Click;
                }
                break;
            case 3: // MainPage.xaml line 14
                {
                    global::Windows.UI.Xaml.Controls.AppBarToggleButton element3 = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)element3).Click += this.AppBarButton_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

