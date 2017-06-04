using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Projekat.Kino.Views
{
    public sealed partial class Izbor : Page
    {
        public Izbor()
        {
            this.InitializeComponent();
        }
        public void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(UnosUposlenog));
        }
        public void buttonObrisi_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(BrisanjeUposlenog));
        }
    }
}
