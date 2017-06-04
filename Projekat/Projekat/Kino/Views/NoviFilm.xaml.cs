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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Projekat.Azure;

namespace Projekat.Kino.Views
{
    public sealed partial class NoviFilm : Page
    {
        IMobileServiceTable<Azure.Film> userTableObj = App.MobileService.GetTable<Azure.Film>();

        private byte[] uploadSlika;
        public async void slika_Click(object sender, RoutedEventArgs e)
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
        

        private async void dodajFilm_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new Kino.Models.KinoDbContext())
                {
                    

                    IMobileServiceTable<Azure.Film> userTableObj = App.MobileService.GetTable<Azure.Film>();
                    try
                    {
                        Azure.Film obj = new Azure.Film();
                        // obj.zanr = combozanr.;
                        obj.naziv = nazivFilma.Text.ToString();

                        obj.id = "1";
                        obj.godina = Convert.ToInt32(godinaFilma.Text);
                       // obj.trajanje = Convert.ToInt32(trajanjeFilma.);
                        obj.plot = plotFilma.DataContext.ToString();
                        obj.imdb = imdbFilma.Text;
                        
                        await userTableObj.InsertAsync(obj);
                        MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novi film.");
                        await msgDialog.ShowAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " +
                        ex.ToString());
                        // msgDialogError.ShowAsync();
                    }

                    nazivFilma.Text = string.Empty;
                    godinaFilma.Text = string.Empty;
                    imdbFilma.Text = string.Empty;
                    imdbFilma.Text = string.Empty;
                    combozanr.PlaceholderText = "zanr";
                   // trajanjeFilma.po
                }
            }
            catch (Exception izuzetak)
            {
                var dialog1 = new MessageDialog(izuzetak.Message);
                dialog1.Commands.Add(new UICommand { Label = "Ok" });
                await dialog1.ShowAsync();
            }
        }
    }
    }
