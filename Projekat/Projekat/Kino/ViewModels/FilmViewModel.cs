using Projekat.Kino.Helper;
using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekat.Kino.ViewModels
{
    public class FilmViewModel
    {
        public NavigationService NavigationService { get; set; }
        public ICommand DodajFilmInfo { get; set; }
        public Film film { get; set; }
        public FilmViewModel(int id)
        {
            using (var db = new KinoDbContext())
            {
                var k = db.Filmovi.Where(c => c.filmId == id).FirstOrDefault();
                film = new Film();
                film.filmId = k.filmId;
                film.godina = k.godina;
                film.imdb = k.imdb;
                film.naziv = k.naziv;
                film.plot = k.plot;
                film.Slika = k.Slika;
                film.trajanje = k.trajanje;
                film.zanr = k.zanr;
            }
            NavigationService = new NavigationService();
            DodajFilmInfo = new RelayCommand<object>(dodavanje);

        }
        public void dodavanje(object parametar)
        {
            NavigationService.GoBack();
        }
    }
}
