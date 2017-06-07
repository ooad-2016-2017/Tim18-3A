using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Teamer.View;
using Teamer.ViewModel;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Teamer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private LoginViewModel viewModel; 
        public MainPage()
        {
            this.InitializeComponent();
            viewModel = new LoginViewModel();
            this.DataContext = viewModel;
            this.ButtonsControl.Register += new EventHandler(OpenRegistration);
            this.ButtonsControl.Login += new EventHandler(Login);
        }

        public void Login(object sender, EventArgs e)
        {
            KorisnikVM korisnik;
            if((korisnik = viewModel.PretraziKorisnike()) != null)
            {
                var frame = (Frame)Window.Current.Content;
                switch (viewModel.tip)
                {
                    case 0: frame.Navigate(typeof(MenadzerIzborTima), korisnik);
                        break;
                    case 1: frame.Navigate(typeof(TrenerTimRaspored), korisnik);
                        break;
                    case 2:
                        frame.Navigate(typeof(IgracTimRaspored), korisnik);
                        break;
                }
            }
        }
        public void OpenRegistration(object sender, EventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(Registration), null);
        }

    }
}
