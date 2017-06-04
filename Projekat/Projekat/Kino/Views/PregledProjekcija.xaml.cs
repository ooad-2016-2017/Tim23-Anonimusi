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
    public sealed partial class PregledProjekcija : Page
    {
        public PregledProjekcija()
        {
            DataContext = new ListaProjekcijaViewModel();

            this.InitializeComponent();
            
        }
       public void detalji_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            Film f;
            Projekcija p = (Projekcija) listaProjekcija.SelectedValue;
            using (var db = new KinoDbContext()) {
                f = db.Filmovi.OrderBy(c => c.filmId == p.idFilma).FirstOrDefault();
            }
            rootFrame.Navigate(typeof(DetaljiFilma), f);
        }
        
}
}
