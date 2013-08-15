using Meteo_Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
        Location currentLocation;
        Model currentModel = Model.UM;
        City currentCity;
        Source currentSource;

        Dictionary<City, string> titles = new Dictionary<City, string>();

        public MainWindow()
        {
            InitializeComponent();

            titles.Add(City.BIALYSTOK, "Białystok");
            titles.Add(City.BYDGOSZCZ, "Bydgoszcz");
            titles.Add(City.GDANSK, "Gdańsk");
            titles.Add(City.GORZOW_WIELKOPOLSKI, "Gorzów Wielkopolski");
            titles.Add(City.KATOWICE, "Katowice");
            titles.Add(City.KIELCE, "Kielce");
            titles.Add(City.KRAKOW, "Kraków");
            titles.Add(City.LODZ, "Łódź");
            titles.Add(City.LUBLIN, "Lublin");
            titles.Add(City.OLSZTYN, "Olsztyn");
            titles.Add(City.OPOLE, "Opole");
            titles.Add(City.POZNAN, "Poznań");
            titles.Add(City.RZESZOW, "Rzeszów");
            titles.Add(City.SZCZECIN, "Szczecin");
            titles.Add(City.TORUN, "Toruń");
            titles.Add(City.WARSZAWA, "Warszawa");
            titles.Add(City.WROCLAW, "Wrocław");
            titles.Add(City.ZIELONA_GORA, "Zielona Góra");
        }

        private void SetImage(MemoryStream ms, string title)
        {
            var imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = ms;
            imageSource.EndInit();
            imgMeteo.Source = imageSource;
            cmdSwitch.IsEnabled = true;
            this.Title = "Meteo - " + title;
        }

        private async Task SetCity(City city, Model model)
        {
            Loading(true);
            try
            {
                var stream = await Meteo.MainCity(city, model);
                SetImage(stream, titles[city]);
                cmdSave.IsEnabled = false;
                currentCity = city;
                currentModel = model;
                currentSource = Source.MAIN_CITY;
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
            await SetCity(City.BIALYSTOK, currentModel);
        }

        private async void meteoBydgoszcz_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.BYDGOSZCZ, currentModel);
        }

        private async void meteoGdansk_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.GDANSK, currentModel);
        }

        private async void meteoGorzow_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.GORZOW_WIELKOPOLSKI, currentModel);
        }

        private async void meteoKatowice_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.KATOWICE, currentModel);
        }

        private async void meteoKielce_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.KIELCE, currentModel);
        }

        private async void meteoKrakow_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.KRAKOW, currentModel);
        }

        private async void meteoLublin_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.LUBLIN, currentModel);
        }

        private async void meteoLodz_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.LODZ, currentModel);
        }

        private async void meteoOlsztyn_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.OLSZTYN, currentModel);
        }

        private async void meteoOpole_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.OPOLE, currentModel);
        }

        private async void meteoPoznan_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.POZNAN, currentModel);
        }

        private async void meteoRzeszow_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.RZESZOW, currentModel);
        }

        private async void meteoSzczecin_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.SZCZECIN, currentModel);
        }

        private async void meteoTorun_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.TORUN, currentModel);
        }

        private async void meteoWarszawa_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.WARSZAWA, currentModel);
        }

        private async void meteoWroclaw_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.WROCLAW, currentModel);
        }

        private async void meteoZielonaGora_Click(object sender, RoutedEventArgs e)
        {
            await SetCity(City.ZIELONA_GORA, currentModel);
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
                currentSource = Source.MAP;
                Loading(true);
                try
                {
                    currentLocation = Meteo.GetLocation(new Coordinates(map.PinLocation.Latitude, map.PinLocation.Longitude));
                    var img = await currentLocation.Get(currentModel);
                    SetImage(img, currentLocation.ToString() + " (" + currentModel.ToString() + ")");
                    cmdSave.IsEnabled = true;
                }
                catch (Meteo_Lib.ResolveException)
                {
                    MessageBox.Show(this, "Podana pozycja nie mieści się w obszarze danego modelu", "Błąd", MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                finally
                {
                    Loading(false);
                }
            }
        }

        private void cmdSave_Click(object sender, RoutedEventArgs e)
        {
            var save = new SaveFav();
            save.Owner = this;
            var result = save.ShowDialog();
            if (result != null && result == true)
            {
                //TODO
            }
        }

        private void listFavs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listFavs.SelectedItem != null)
            {
                Loading(true);

                Loading(false);
            }
        }

        private async void cmdSwitch_Click(object sender, RoutedEventArgs e)
        {
            switch (currentSource)
            {
                case Source.FAV:
                    break;
                case Source.MAP:
                    switch (currentModel)
                    {
                        case Model.COAMPS:
                            {
                                currentModel = Model.UM;
                                Loading(true);
                                var img = await currentLocation.Get(Model.UM);
                                Loading(false);
                                SetImage(img, currentLocation.ToString() + " (" + currentModel.ToString() + ")");
                                break;
                            }
                        case Model.UM:
                            {
                                currentModel = Model.COAMPS;
                                Loading(true);
                                var img = await currentLocation.Get(Model.COAMPS);
                                Loading(false);
                                SetImage(img, currentLocation.ToString() + " (" + currentModel.ToString() + ")");
                                break;
                            }
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                case Source.MAIN_CITY:
                    switch (currentModel)
                    {
                        case Model.COAMPS:
                            {
                                currentModel = Model.UM;
                                await SetCity(currentCity, Model.UM);
                                break;
                            }
                        case Model.UM:
                            {
                                currentModel = Model.COAMPS;
                                await SetCity(currentCity, Model.COAMPS);
                                break;
                            }
                        default:
                            throw new NotImplementedException();
                    }
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void cmdAbout_Click(object sender, RoutedEventArgs e)
        {
            (new AboutBox1()).ShowDialog();
        }
    }
}
