using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Text.RegularExpressions;
using Teamer.ViewModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Teamer.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registration : Page
    {
        private RegistrationViewModel viewModel;
        public Registration()
        {
            this.InitializeComponent();
            viewModel = new RegistrationViewModel();
            this.DataContext = viewModel;
            this.RadioButtoni.Menadzer += new EventHandler(OznaciMenadzera);
            this.RadioButtoni.Igrac += new EventHandler(OznaciIgraca);
            this.RadioButtoni.Trener += new EventHandler(OznaciTrenera);
        }
        bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        public void OznaciMenadzera(object sender, EventArgs e)
        {
            this.viewModel.OznaciMenadzera();
        }
        public void OznaciTrenera(object sender, EventArgs e)
        {
            this.viewModel.OznaciTrenera();
        }
        public void OznaciIgraca(object sender, EventArgs e)
        {
            this.viewModel.OznaciIgraca();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var korisnik = this.viewModel.KreirajKorisnika();
            if (korisnik != null)
            {
                var dialog = new MessageDialog("Korisnik uspjesno kreiran");
                await dialog.ShowAsync();
                Frame frame = (Frame)Window.Current.Content;
                frame.Navigate(typeof(MenadzerIzborTima), korisnik);
            }
            else
            {
                var dialog = new MessageDialog(viewModel.ProvjeriParametre());
                await dialog.ShowAsync();
            }
        }
        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    bool korektno = true;

        //if (emailUC.Vrijednost == "" || userNameUC.Username == "" || passwordUC.Vrijednost == "" || cPasswordUC.Vrijednost == "")
        //{
        //    korektno = false;

        //    var dialog = new MessageDialog("Nisu uneseni svi podaci!", "GREŠKA");
        //    await dialog.ShowAsync();
        //}
        //else if (!(IsValidEmail(emailUC.Vrijednost)))
        //{
        //    korektno = false;

        //    var dialog = new MessageDialog("Pogrešna forma email-a!", "GREŠKA");
        //    await dialog.ShowAsync();
        //}
        //else if (passwordUC.Vrijednost != cPasswordUC.Vrijednost)
        //{
        //    korektno = false;

        //    var dialog = new MessageDialog("Šifre nisu identične!", "GREŠKA");
        //    await dialog.ShowAsync();
        //}

        //if(korektno)
        //{
        //    Frame frame = Window.Current.Content as Frame;
        //    frame.Navigate(typeof(MenadzerIzborTima), null);
        //}
        //    Frame frame = Window.Current.Content as Frame;
        //    frame.Navigate(typeof(MenadzerIzborTima), null);
        //}
    }
}
