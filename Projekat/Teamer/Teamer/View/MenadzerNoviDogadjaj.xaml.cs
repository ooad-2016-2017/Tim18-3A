using Microsoft.Data.Entity.Metadata;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Teamer.User_Controls;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Teamer.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MenadzerNoviDogadjaj : Page
    {
        public MenadzerNoviDogadjaj()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            frame.Navigate(typeof(MenadzerNoviDogadjajPosaljiPoziv), null);
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            var locator = new Geolocator();
            locator.DesiredAccuracyInMeters = 50;
            var position = await locator.GetGeopositionAsync();
            await mapControl.TrySetViewAsync(position.Coordinate.Point, 16);
            MapIcon pin = new MapIcon();
            pin.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Images/Icons/PlaceholderPin.png"));
            pin.Title = "Trenutna lokacija";
            pin.Location = new Geopoint(new BasicGeoposition() { Latitude = position.Coordinate.Point.Position.Latitude, Longitude = position.Coordinate.Point.Position.Longitude });
            pin.NormalizedAnchorPoint = new Point(0.5, 0.5);
            mapControl.MapElements.Add(pin);
        }


        private async void LokacijaUC_LostFocus(object sender, RoutedEventArgs e)
        {
            var address = LokacijaUC.Vrijednost;

            if (String.IsNullOrEmpty(address)) return;

            var results = await MapLocationFinder.FindLocationsAsync(address, null);
            if (results.Status == MapLocationFinderStatus.Success)
            {
                var point = results.Locations[0].Point;

                await mapControl.TrySetViewAsync(point, 16);
                MapIcon pin = new MapIcon();
                pin.Image = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Images/Icons/PlaceholderPin.png"));
                pin.Title = "Unesena lokacija";
                pin.Location = new Geopoint(new BasicGeoposition() { Latitude = point.Position.Latitude, Longitude = point.Position.Longitude });
                pin.NormalizedAnchorPoint = new Point(0.5, 0.5);
                mapControl.MapElements.Add(pin);
            }
        }
    }
}