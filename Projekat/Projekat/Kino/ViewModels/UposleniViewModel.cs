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
    public class UposleniViewModel
    {
        public NavigationService NavigationService { get; set; }
        public ICommand DodajUposleniInfo { get; set; }
        public Uposleni uposleni { get; set; }
        public UposleniViewModel(int id)
        {

            using (var db = new KinoDbContext())
            {
                uposleni = db.Uposlenici.Where(c => c.UposleniId == id).FirstOrDefault();
                
            }
            NavigationService = new NavigationService();
            DodajUposleniInfo = new RelayCommand<object>(dodavanje);

        }
        public void dodavanje(object parametar)
        {
            NavigationService.GoBack();
        }
    }
}
