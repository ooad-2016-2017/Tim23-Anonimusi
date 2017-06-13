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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Projekat.Kino.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NoviClan : Page
    {
        IMobileServiceTable<Azure.Clan> userTableObj = App.MobileService.GetTable<Azure.Clan>();
        private byte[] uploadSlika;



        public NoviClan()
        {
            this.InitializeComponent();
            prvi.Visibility.Equals(false);
            drugi.Visibility.Equals(false);
        }


        private void DA_Click(object sender, RoutedEventArgs e)
        {
            prvi.Visibility.Equals(true);
        }

        private void NE_Click(object sender, RoutedEventArgs e)
        {
            var rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(KupovinaUlaznica1));
        }

        private void gotovo_click(object sender, RoutedEventArgs e)
        {

            if (!maticniBroj.Text.Length.Equals(13))
            {
                var dialog = new MessageDialog("Pogrešno unesen matični broj! Pokušajte ponovo");
                ime.Text = string.Empty;
                prezime.Text = string.Empty;
                maticniBroj.Text = string.Empty;
                grad.SelectedIndex.Equals(0);

            }
            else drugi.Visibility.Equals(true);


        }

        private async void slika_click(object sender, RoutedEventArgs e)
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

        private void odustani_click(object sender, RoutedEventArgs e)
        {

        }

        private async void potvrdi_click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new Kino.Models.KinoDbContext())
                {


                    IMobileServiceTable<Azure.Clan> userTableObj = App.MobileService.GetTable<Azure.Clan>();
                    try
                    {
                        Azure.Clan obj = new Azure.Clan();
                        // obj.zanr = combozanr.;
                        obj.ime = ime.Text.ToString();

                        obj.id = "1";
                        obj.prezime = prezime.Text;
                        obj.maticniBroj = maticniBroj.Text;
                        obj.grad = grad.SelectedItem.ToString();


                        await userTableObj.InsertAsync(obj);
                        MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novi film.");
                        await msgDialog.ShowAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageDialog msgDialogError = new MessageDialog("Error : " +
                        ex.ToString());

                    }

                    ime.Text = string.Empty;
                    prezime.Text = string.Empty;

                    maticniBroj.Text = string.Empty;


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
