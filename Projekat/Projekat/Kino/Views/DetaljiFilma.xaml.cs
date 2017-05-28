using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Projekat.Kino.Views
{
    public sealed partial class DetaljiFilma : Page
    {
        public DetaljiFilma()
        {
            this.InitializeComponent();
           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Film film = e.Parameter as Film;
            detalji.ItemsSource = film;
        }
        public void nazad_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(PregledFilma));
        }
    }
}
