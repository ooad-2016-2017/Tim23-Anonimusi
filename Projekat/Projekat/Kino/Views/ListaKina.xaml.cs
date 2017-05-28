using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Projekat.Kino.Views
{
    public sealed partial class ListaKina : Page
    {
        public ListaKina()
        {
            this.InitializeComponent();
            using (var db = new KinoDbContext())
            {
                listaKina.ItemsSource=db.Kina.OrderBy(c => c.adresa).ToList();
                
            }
        }
        
        public void dodaj_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(NovoKino));
        }
        public void edit_Click(object sender, RoutedEventArgs e)
        {
            if ((listaKina.SelectedItems.Count()) == 1)
            {
                var rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(UrediKino), (Models.Kino)listaKina.SelectedValue);
            }
        }
        public void obrisi_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new KinoDbContext())
            {
                if ((listaKina.SelectedItems.Count()) == 1)
                {
                    db.Kina.Remove((Models.Kino)listaKina.SelectedItem);
                    db.SaveChanges();
                    listaKina.ItemsSource = db.Kina.OrderBy(c => c.adresa).ToList();
                }
            }
        }
    }
}
