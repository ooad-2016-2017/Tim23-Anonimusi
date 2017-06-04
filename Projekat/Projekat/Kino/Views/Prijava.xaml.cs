using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

namespace Projekat.Kino.Views
{
    public sealed partial class Prijava : Page
    {
        public Prijava()
        {
            this.InitializeComponent();
            Sistem s = new Sistem();
        }
        public async void adminPrijava_Click(object sender, RoutedEventArgs e)
        {
            var korisnicko = korisnickoIme.Text;
                var sifra = lozinka.Password;
                Boolean tacno = Sistem.provjeraKorisnika(korisnicko, sifra);
            if (tacno) { 
                var rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(AdminMeni));
            }
            else
            {
                var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!", "Neuspješna prijava");
                await dialog.ShowAsync();
                korisnickoIme.Text = String.Empty;
                lozinka.Password = "";
            }
            
            
        }
    }
}
