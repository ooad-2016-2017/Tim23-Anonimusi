using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Projekat.Kino.Views
{
    public sealed partial class PregledKina : Page
    {
        public PregledKina()
        {
            this.InitializeComponent();
        }
        public void ok_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(IzaberiProjekciju));
        }
    }
}
