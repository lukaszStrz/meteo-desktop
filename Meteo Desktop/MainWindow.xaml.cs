﻿using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Meteo_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Meteo_Lib.Meteo meteo = new Meteo_Lib.Meteo();

        Meteo_Lib.Coordinates currentCoordinates;

        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.favs == null)
                Properties.Settings.Default.favs = new SerializableStringDictionary();
            LoadFavs();
        }

        private void LoadFavs()
        {
            Loading(true);
            listFavs.Items.Clear();
            foreach (var item in Properties.Settings.Default.favs.Keys)
            {
                listFavs.Items.Add(new Fav((string)item, Properties.Settings.Default.favs[(string)item]));
            }
            Loading(false);
        }

        private void SetImage(MemoryStream ms)
        {
            var imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = ms;
            imageSource.EndInit();
            imgMeteo.Source = imageSource;
        }

        private void Loading(bool loading)
        {
            if (loading)
            {
                this.Cursor = System.Windows.Input.Cursors.Wait;
            }
            else
            {
                this.Cursor = System.Windows.Input.Cursors.Arrow;
            }
        }

        #region Main Cities

        private async void meteoBialystok_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.BialystokUM();
                SetImage(stream);
                this.Title = "Meteo - Białystok (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoBydgoszcz_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.BydgoszczUM();
                SetImage(stream);
                this.Title = "Meteo - Bydgoszcz (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoGdansk_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.GdanskUM();
                SetImage(stream);
                this.Title = "Meteo - Gdańsk (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoGorzow_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.GorzowUM();
                SetImage(stream);
                this.Title = "Meteo - Gorzów Wielkopolski (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoKatowice_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.KatowiceUM();
                SetImage(stream);
                this.Title = "Meteo - Katowice (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoKielce_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.KielceUM();
                SetImage(stream);
                this.Title = "Meteo - Kielce (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoKrakow_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.KrakowUM();
                SetImage(stream);
                this.Title = "Meteo - Kraków (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoLublin_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.LublinUM();
                SetImage(stream);
                this.Title = "Meteo - Lublin (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoLodz_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.LodzUM();
                SetImage(stream);
                this.Title = "Meteo - Łódź (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoOlsztyn_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.OlsztynUM();
                SetImage(stream);
                this.Title = "Meteo - Olsztyn (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoOpole_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.OpoleUM();
                SetImage(stream);
                this.Title = "Meteo - Opole (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoPoznan_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.PoznanUM();
                SetImage(stream);
                this.Title = "Meteo - Poznań (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoRzeszow_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.RzeszowUM();
                SetImage(stream);
                this.Title = "Meteo - Rzeszów (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoSzczecin_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.SzczecinUM();
                SetImage(stream);
                this.Title = "Meteo - Szczecin (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoTorun_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.TorunUM();
                SetImage(stream);
                this.Title = "Meteo - Toruń (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoWarszawa_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.WarszawaUM();
                SetImage(stream);
                this.Title = "Meteo - Warszawa (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoWroclaw_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.WroclawUM();
                SetImage(stream);
                this.Title = "Meteo - Wrocław (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        private async void meteoZielonaGora_Click(object sender, RoutedEventArgs e)
        {
            Loading(true);
            try
            {
                var stream = await meteo.ZielonaGoraUM();
                SetImage(stream);
                this.Title = "Meteo - Zielona Góra (UM)";
                cmdSave.IsEnabled = false;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading(false);
            }
        }

        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private async void cmdMap_Click(object sender, RoutedEventArgs e)
        {
            var map = new Map();
            map.Owner = this;
            var result = map.ShowDialog();
            if (result != null && result == true)
            {
                currentCoordinates = new Meteo_Lib.Coordinates(map.PinLocation.Latitude, map.PinLocation.Longitude);
                var img = await meteo.UM(currentCoordinates);
                SetImage(img);
                cmdSave.IsEnabled = true;
                this.Title = "Meteo - " + map.PinLocation.ToString() + " (UM)";
            }
        }

        private void cmdSave_Click(object sender, RoutedEventArgs e)
        {
            var save = new SaveFav();
            save.Owner = this;
            var result = save.ShowDialog();
            if (result != null && result == true)
            {
                if (Properties.Settings.Default.favs.ContainsKey(save.Key))
                {
                    MessageBox.Show(this, "Podana nazwa już znajduje się w ulubionych", "Błąd", MessageBoxButton.OK, MessageBoxImage.Stop);
                    return;
                }
                StringBuilder val = new StringBuilder();
                val.Append(currentCoordinates.NALL);
                val.Append(';');
                val.Append(currentCoordinates.EALL);
                Properties.Settings.Default.favs.Add(save.Key, val.ToString());
                cmdSave.IsEnabled = false;
                LoadFavs();
            }
        }

        private async void listFavs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listFavs.SelectedItem != null)
            {
                Loading(true);
                var item = (Fav)listFavs.SelectedItem;
                currentCoordinates = item.Coord;
                var img = await meteo.UM(currentCoordinates);
                SetImage(img);
                cmdSave.IsEnabled = false;
                this.Title = "Meteo - " + item.Name + " (UM)";
                Loading(false);
            }
        }
    }
}
