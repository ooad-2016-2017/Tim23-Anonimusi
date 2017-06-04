using Projekat.Kino.Models;
using Projekat.Kino.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Projekat.Kino.Views
{
    public sealed partial class PregledFilma : Page
    {
        public PregledFilma()
        {
            DataContext = new ListaFilmovaViewModel();
            this.InitializeComponent();
           
        }
        public void dodaj_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DodavanjeProjekcije1));
        }
        public void detalji_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(DetaljiFilma), (Film) listaFilmova.SelectedValue);
        }
        public void obrisi_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new KinoDbContext())
            {
                if (listaFilmova.SelectedItems.Count==1)
                {
                    db.Filmovi.Remove((Models.Film)listaFilmova.SelectedItem);
                    db.SaveChanges();
                    listaFilmova.ItemsSource = db.Filmovi.OrderBy(c => c.filmId).ToList();
                }
            }
        }
        public void novi_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(NoviFilm));
        }
    }
}
