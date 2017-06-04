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
    public class ListaKinaViewModel
    {
        public NavigationService NavigationService { get; set; }
        public ICommand DodajKina { get; set; }
        public List<Models.Kino> kina { get; set; }
        public ListaKinaViewModel()
        {
            kina = new List<Models.Kino>();
            using (var db = new KinoDbContext())
            {
                kina = db.Kina.OrderBy(c => c.adresa).ToList();
            }
            NavigationService = new NavigationService();
            DodajKina = new RelayCommand<object>(dodavanje);

        }
        public void dodavanje(object parametar)
        {
            NavigationService.GoBack();
        }
    }
}

