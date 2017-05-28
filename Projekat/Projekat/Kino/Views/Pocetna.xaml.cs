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
    public sealed partial class Pocetna : Page
    {
        public Pocetna()
        {
            this.InitializeComponent();
            Projekat.Kino.Models.DefaultVrijednostiKino.Initialize(new KinoDbContext());
        }

      
        public void ok_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

