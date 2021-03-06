﻿using Projekat.Kino.Models;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Core;
using Projekat.Kino.ViewModels;

namespace Projekat.Kino.Views
{
    public sealed partial class NovoKino : Page
    {
        public NovoKino()
        {
            
            this.InitializeComponent();

        }
       private void generisi_Click(object sender, RoutedEventArgs e)
        {
            using (var db=new KinoDbContext())
            {
                Film film = db.Filmovi.OrderBy(c => c.filmId).Last();
                int id = film.filmId + 1;
                idKina.Text = id.ToString();
            }
        }
        private void dugmeDodajKino_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new Models.KinoDbContext())
            {
                var contact = new Kino.Models.Kino
                {
                    kinoId = int.Parse(idKina.Text),
                    adresa = adresaKina.Text,
                    grad = ((ComboBoxItem)grad.SelectedItem).Content.ToString(),
                    telefon= telefon.Text,
                    email= emailKina.Text,
                };
                db.Kina.Add(contact);
                
                db.SaveChanges();
                //reset polja za unos
                idKina.Text = string.Empty;
                adresaKina.Text = string.Empty;
                grad.SelectedValue = "";
                telefon.Text = string.Empty;
                emailKina.Text = string.Empty;
                  
            }
            var rootFrame = Window.Current.Content as Frame;
                rootFrame.Navigate(typeof(ListaKina));
        }
      
    }
}
