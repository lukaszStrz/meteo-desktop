﻿using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Meteo_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Meteo_Lib.Meteo meteo = new Meteo_Lib.Meteo();

        bool loading = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetImage(MemoryStream ms)
        {
            var imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = ms;
            imageSource.EndInit();
            imgMeteo.Source = imageSource;
        }

        private void Loading()
        {
            if (!loading)
            {
                this.Cursor = System.Windows.Input.Cursors.Wait;
                loading = true;
            }
            else
            {
                this.Cursor = System.Windows.Input.Cursors.Arrow;
                loading = false;
            }
        }

        #region Main Cities

        private async void meteoBialystok_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.BialystokUM();
                SetImage(stream);
                this.Title = "Meteo - Białystok (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoBydgoszcz_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.BydgoszczUM();
                SetImage(stream);
                this.Title = "Meteo - Bydgoszcz (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoGdansk_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.GdanskUM();
                SetImage(stream);
                this.Title = "Meteo - Gdańsk (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoGorzow_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.GorzowUM();
                SetImage(stream);
                this.Title = "Meteo - Gorzów Wielkopolski (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoKatowice_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.KatowiceUM();
                SetImage(stream);
                this.Title = "Meteo - Katowice (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoKielce_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.KielceUM();
                SetImage(stream);
                this.Title = "Meteo - Kielce (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoKrakow_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.KrakowUM();
                SetImage(stream);
                this.Title = "Meteo - Kraków (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoLublin_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.LublinUM();
                SetImage(stream);
                this.Title = "Meteo - Lublin (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoLodz_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.LodzUM();
                SetImage(stream);
                this.Title = "Meteo - Łódź (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoOlsztyn_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.OlsztynUM();
                SetImage(stream);
                this.Title = "Meteo - Olsztyn (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoOpole_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.OpoleUM();
                SetImage(stream);
                this.Title = "Meteo - Opole (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoPoznan_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.PoznanUM();
                SetImage(stream);
                this.Title = "Meteo - Poznań (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoRzeszow_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.RzeszowUM();
                SetImage(stream);
                this.Title = "Meteo - Rzeszów (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoSzczecin_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.SzczecinUM();
                SetImage(stream);
                this.Title = "Meteo - Szczecin (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoTorun_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.TorunUM();
                SetImage(stream);
                this.Title = "Meteo - Toruń (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoWarszawa_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.WarszawaUM();
                SetImage(stream);
                this.Title = "Meteo - Warszawa (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoWroclaw_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.WroclawUM();
                SetImage(stream);
                this.Title = "Meteo - Wrocław (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        private async void meteoZielonaGora_Click(object sender, RoutedEventArgs e)
        {
            Loading();
            try
            {
                var stream = await meteo.ZielonaGoraUM();
                SetImage(stream);
                this.Title = "Meteo - Zielona Góra (UM)";
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie z siecią", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Loading();
            }
        }

        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
