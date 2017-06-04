using Projekat.Kino.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Projekat.Kino.Views
{
    public sealed partial class PrvaStranica : Page
    {
        public PrvaStranica()
        {
            this.InitializeComponent();
            
        }
        public void prijava_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(Prijava));
        }
        public void birajKino_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(Pocetna));
        }
        public void projekcije_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(PregledProjekcija));
        }  
    }
}
