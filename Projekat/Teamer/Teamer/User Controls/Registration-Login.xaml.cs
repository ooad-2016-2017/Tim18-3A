using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Teamer.View;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Teamer.User_Controls
{
    public sealed partial class Registration_Login : UserControl
    {
        public EventHandler Register;
        public EventHandler Login;
        public Registration_Login()
        {
            this.InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.Login != null)
            {
                this.Login(this, new EventArgs());
            }
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            if(this.Register != null)
            {
                this.Register(this, new EventArgs());
            }
        }
    }
}
