using Projekat.Kino.Helper;
using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projekat.Kino.ViewModels
{
    public class KinoViewModel 
    {
        public NavigationService NavigationService { get; set; }
        public ICommand DodajKinoInfo { get; set; }
        public Models.Kino kino { get; set; }
        public KinoViewModel(int id)
        {
           
            using (var db=new KinoDbContext())
            {
                var k = db.Kina.Where(c => c.kinoId == id).FirstOrDefault();
                kino= new Models.Kino();
                kino.kinoId = k.kinoId;
                kino.adresa = k.adresa;
                kino.grad = k.grad;
                kino.telefon = k.telefon;
                kino.email = k.email;
                kino.brojSala = k.brojSala;
            }
            NavigationService = new NavigationService();
            DodajKinoInfo = new RelayCommand<object>(dodavanje);

        }
        public void dodavanje(object parametar)
        {
            NavigationService.GoBack();
        }
    }
}
