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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Windows.Storage.Pickers;
using Windows.Storage;
using Projekat.Kino.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UnosUposlenog : Page
    {
        Random ran;
        IMobileServiceTable<Azure.Uposleni> userTableObj = App.MobileService.GetTable<Azure.Uposleni>();
        private byte[] uploadSlika;

        public UnosUposlenog()
        {
            this.InitializeComponent();
            ran = new Random();
        }

        private async void unesi(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new Kino.Models.KinoDbContext())
                {


                    IMobileServiceTable<Azure.Uposleni> userTableObj = App.MobileService.GetTable<Azure.Uposleni>();
                    try
                    {
                        Azure.Uposleni obj = new Azure.Uposleni();
                        // obj.zanr = combozanr.;
                        obj.ime = ime.Text.ToString();

                        obj.id = "1";
                        obj.prezime = prezime.Text;
                        // obj.trajanje = Convert.ToInt32(trajanjeFilma.);
                        obj.maticniBroj = maticniBroj.Text;
                        obj.korisnickoIme = korisnickoIme.Text;
                        obj.sifra = sifra.Password.ToString();

                        await userTableObj.InsertAsync(obj);
                        MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog uposlenika.");
                        await msgDialog.ShowAsync();

                        Uposleni up = new Uposleni();
                        up.Ime = ime.Text.ToString();

                        up.UposleniId = ran.Next(10, 190);
                        obj.prezime = prezime.Text;
                        up.MaticniBroj = maticniBroj.Text;
                        up.KorisnickoIme = korisnickoIme.Text;
                        up.Sifra = sifra.Password.ToString();

                        db.Uposlenici.Add(up);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());

                    }

                    ime.Text = string.Empty;
                    prezime.Text = string.Empty;
                    korisnickoIme.Text = string.Empty;
                    maticniBroj.Text = string.Empty;
                    sifra.Password = string.Empty;

                }
            }
            catch (Exception izuzetak)
            {
                var dialog1 = new MessageDialog(izuzetak.Message);
                dialog1.Commands.Add(new UICommand { Label = "Ok" });
                await dialog1.ShowAsync();
            }
        }



        private async void ucitajSliku(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new Windows.Storage.Pickers.FileOpenPicker();
            openPicker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation =
            Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            openPicker.FileTypeFilter.Add(".jpg");
            openPicker.FileTypeFilter.Add(".jpeg");
            openPicker.FileTypeFilter.Add(".png");
            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                uploadSlika = (await Windows.Storage.FileIO.ReadBufferAsync(file)).ToArray(); ;

            }
        }
    }
}
