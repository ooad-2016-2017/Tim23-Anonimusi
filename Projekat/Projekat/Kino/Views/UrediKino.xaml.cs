using Microsoft.Data.Entity;
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
    public sealed partial class UrediKino : Page
    {
        private Models.Kino kino;
        public UrediKino()
        {
            
            this.InitializeComponent();
            
        }
        public void spremi_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new KinoDbContext())
            {
                kino.adresa = adresaKina.Text;
                kino.telefon = telefon.Text;
                kino.email= emailKina.Text;
                db.Entry(kino).State = EntityState.Modified;
                db.SaveChanges();
                //refresh liste restorana

                idKina.Text = "ID-broj kina: ";
                grad.SelectedValue = String.Empty;
                adresaKina.Text = String.Empty;
                telefon.Text = String.Empty;
                emailKina.Text = String.Empty;  
            }
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(ListaKina));
        }
        public void ponisti_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(ListaKina));
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.Content!=null)
            {
                this.kino = (Models.Kino)e.Parameter;
                DataContext = new KinoViewModel(kino.kinoId);
                idKina.Text += kino.kinoId.ToString();
            }
        }
    }
}
