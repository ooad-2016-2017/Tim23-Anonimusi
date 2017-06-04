using Projekat.Kino.Models;
using Projekat.Kino.ViewModels;
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
        private Film film;
        public DetaljiFilma()
        {
            this.InitializeComponent();
           
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Content != null)
            {
                this.film = (Film)e.Parameter;
                DataContext = new FilmViewModel(film.filmId);
            }
        }
        public void nazad_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(PregledFilma));
        }
    }
}
