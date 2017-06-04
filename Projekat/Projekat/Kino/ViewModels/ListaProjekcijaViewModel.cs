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
    public class ListaProjekcijaViewModel
    {
        public NavigationService NavigationService { get; set; }
        public ICommand DodajProjekcije { get; set; }
        public List<Projekcija> projekcije { get; set; }
 
        public ListaProjekcijaViewModel()
        {
            projekcije = new List<Projekcija>();
            using (var db = new KinoDbContext())
            {
                projekcije = db.Projekcije.OrderBy(c => c.idFilma).ToList();
                
            }
            NavigationService = new NavigationService();
            DodajProjekcije = new RelayCommand<object>(dodavanje);

        }
        public void dodavanje(object parametar)
        {
            NavigationService.GoBack();
        }
    }
}
