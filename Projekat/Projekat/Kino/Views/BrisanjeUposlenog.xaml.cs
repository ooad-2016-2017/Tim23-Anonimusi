using Projekat.Azure;
using Projekat.Kino.Models;
using Projekat.Kino.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BrisanjeUposlenog : Page
    {
        public Models.Uposleni uposleni = new Models.Uposleni();
        public BrisanjeUposlenog()
        {
            this.InitializeComponent();
            poruka.Text = "";
        }
        public void trazi_Click(object sender, RoutedEventArgs e)
        {
            if (sifra.Password != "cinerama")
            {
                poruka.Text = "Pogrešna administratorska šifra!";
            }
            else
            {
                poruka.Text = "";
                using (var db = new KinoDbContext())
                {
                    uposleni = db.Uposlenici.OrderBy(c => c.KorisnickoIme == korisnik.Text).FirstOrDefault();
                    DataContext = new UposleniViewModel(uposleni.UposleniId);
                }
            }
        }
        public void obrisi_Click(object sender, RoutedEventArgs e)
        {
            using (var db=new KinoDbContext())
            {
                db.Uposlenici.Remove(uposleni);
                db.SaveChanges();
            }
        }
    }
}
