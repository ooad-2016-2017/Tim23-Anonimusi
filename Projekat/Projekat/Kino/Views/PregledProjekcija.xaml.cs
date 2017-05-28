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
    public sealed partial class PregledProjekcija : Page
    {
        public PregledProjekcija()
        {
            this.InitializeComponent();
            
        }
        public void page_loaded(object sender, RoutedEventArgs e)
        { 
            using (var db = new KinoDbContext())
            {
                listaProjekcija.ItemsSource = db.Projekcije.OrderBy(c => c.idFilma).ToList();
                Film film;
                List<Film> filmovi = db.Filmovi.OrderBy(c => c.filmId).ToList();
                foreach (Projekcija p in db.Projekcije.OrderBy(c => c.idFilma).ToList())
                {
                    film = filmovi.Find(c => (p.idFilma == c.filmId));
                   
                }
            }
            
        }
        
}
}
