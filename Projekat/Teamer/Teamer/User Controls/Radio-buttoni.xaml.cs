using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Radio_buttoni : UserControl
    {
        public EventHandler Menadzer;
        public EventHandler Trener;
        public EventHandler Igrac;
        public Radio_buttoni()
        {
            this.InitializeComponent();
        }

        private void RadioButtonMenadzer_Checked(object sender, RoutedEventArgs e)
        {
            if (this.Menadzer != null)
            {
                this.Menadzer(this, new EventArgs());
            }
        }
        private void RadioButtonTrener_Checked(object sender, RoutedEventArgs e)
        {
            if (this.Trener != null)
            {
                this.Trener(this, new EventArgs());
            }
        }
        private void RadioButtonIgrac_Checked(object sender, RoutedEventArgs e)
        {
            if (this.Igrac != null)
            {
                this.Igrac(this, new EventArgs());
            }
        }
    }
}
