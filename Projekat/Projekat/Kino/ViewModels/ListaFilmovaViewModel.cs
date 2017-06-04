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
    public class ListaFilmovaViewModel
    {
        public NavigationService NavigationService { get; set; }
        public ICommand DodajFilmove { get; set; }
        public List<Film> filmovi { get; set; }
        public ListaFilmovaViewModel()
        {
            filmovi = new List<Film>();
            using (var db = new KinoDbContext())
            {
                filmovi = db.Filmovi.OrderBy(c => c.filmId).ToList();
            }
            NavigationService = new NavigationService();
            DodajFilmove = new RelayCommand<object>(dodavanje);

        }
        public void dodavanje(object parametar)
        {
            NavigationService.GoBack();
        }
    }
}
