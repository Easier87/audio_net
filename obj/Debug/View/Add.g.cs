﻿#pragma checksum "..\..\..\View\Add.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F7DD561A26B900E77A15D8F9CAFAB956E3070D614215977C06331C142152F7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using audio_net.View;


namespace audio_net.View {
    
    
    /// <summary>
    /// Add
    /// </summary>
    public partial class Add : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SelectButt;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image DownIcon;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FilePath;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Box;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox second_tb;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox third_tb;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\Add.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InsertButton;
        
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
            System.Uri resourceLocater = new System.Uri("/audio_net;component/view/add.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Add.xaml"
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
            this.SelectButt = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\View\Add.xaml"
            this.SelectButt.Click += new System.Windows.RoutedEventHandler(this.Select_File_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DownIcon = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.FilePath = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Box = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.second_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.third_tb = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.InsertButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\View\Add.xaml"
            this.InsertButton.Click += new System.Windows.RoutedEventHandler(this.InsertButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

