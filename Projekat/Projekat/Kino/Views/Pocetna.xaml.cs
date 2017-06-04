using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;

namespace Projekat.Kino.Views
{
    public sealed partial class Pocetna : Page , INotifyPropertyChanged
    {
        public Pocetna()
        {
            this.InitializeComponent();
            mapaKina.Loaded += mapaKina_Loaded;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private async void mapaKina_Loaded(object sender, RoutedEventArgs e)
        {
            var center = new Geopoint(new BasicGeoposition()
            {
                Latitude = 48.8530,
                Longitude = 2.3498
            });

            //await mapaVoz.TrySetSceneAsync(MapScene.CreateFromLocationAndRadius(center, 3000));
            if (mapaKina.IsStreetsideSupported)
            {
                //check that map is available for lat and long
                var panorama = await StreetsidePanorama.FindNearbyAsync(mapaKina.Center);

                if (panorama != null)
                {
                    //create custom view
                    mapaKina.CustomExperience = new StreetsideExperience(panorama);
                }
            }

            mapaKina.ZoomLevel = 10;
            mapaKina.Style = MapStyle.AerialWithRoads;
            if (mapaKina.Is3DSupported)
            {
                //set style to 3D
                mapaKina.Style = MapStyle.Aerial3D;

                //create a mapscene for lat and long
                //facing East (90 deg) and pitched 45 deg
                var locator = new Geolocator();
                locator.DesiredAccuracyInMeters = 10;

                var accessStatus = await Geolocator.RequestAccessAsync();
                switch (accessStatus)
                {
                    case GeolocationAccessStatus.Allowed:

                        // Get the current location.
                        Geolocator geolocator = new Geolocator();
                        Geoposition position = await geolocator.GetGeopositionAsync();
                        Geopoint myLocation = position.Coordinate.Point;

                        // Set the map location.
                        var mapScene = MapScene.CreateFromLocationAndRadius(position.Coordinate.Point, 18D);
                        await mapaKina.TrySetSceneAsync(mapScene);
                        break;

                    case GeolocationAccessStatus.Denied:
                        // Handle the case  if access to location is denied.
                        break;

                    case GeolocationAccessStatus.Unspecified:
                        // Handle the case if  an unspecified error occurs.
                        break;
                }

                //var position = await locator.GetGeopositionAsync();

            }
        }

        public void ok_Click(object sender, RoutedEventArgs e)
        {
            
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(IzaberiProjekciju));
    }
    }
}

