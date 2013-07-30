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

        #region Main Cities

        private async void meteoBialystok_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.BialystokUM();
            SetImage(stream);
            this.Title = "Meteo - Białystok (UM)";
        }

        private async void meteoBydgoszcz_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.BydgoszczUM();
            SetImage(stream);
            this.Title = "Meteo - Bydgoszcz (UM)";
        }

        private async void meteoGdansk_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.GdanskUM();
            SetImage(stream);
            this.Title = "Meteo - Gdańsk (UM)";
        }

        private async void meteoGorzow_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.GorzowUM();
            SetImage(stream);
            this.Title = "Meteo - Gorzów Wielkopolski (UM)";
        }

        private async void meteoKatowice_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.KatowiceUM();
            SetImage(stream);
            this.Title = "Meteo - Katowice (UM)";
        }

        private async void meteoKielce_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.KielceUM();
            SetImage(stream);
            this.Title = "Meteo - Kielce (UM)";
        }

        private async void meteoKrakow_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.KrakowUM();
            SetImage(stream);
            this.Title = "Meteo - Kraków (UM)";
        }

        private async void meteoLublin_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.LublinUM();
            SetImage(stream);
            this.Title = "Meteo - Lublin (UM)";
        }

        private async void meteoLodz_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.LodzUM();
            SetImage(stream);
            this.Title = "Meteo - Łódź (UM)";
        }

        private async void meteoOlsztyn_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.OlsztynUM();
            SetImage(stream);
            this.Title = "Meteo - Olsztyn (UM)";
        }

        private async void meteoOpole_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.OpoleUM();
            SetImage(stream);
            this.Title = "Meteo - Opole (UM)";
        }

        private async void meteoPoznan_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.PoznanUM();
            SetImage(stream);
            this.Title = "Meteo - Poznań (UM)";
        }

        private async void meteoRzeszow_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.RzeszowUM();
            SetImage(stream);
            this.Title = "Meteo - Rzeszów (UM)";
        }

        private async void meteoSzczecin_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.SzczecinUM();
            SetImage(stream);
            this.Title = "Meteo - Szczecin (UM)";
        }

        private async void meteoTorun_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.TorunUM();
            SetImage(stream);
            this.Title = "Meteo - Toruń (UM)";
        }

        private async void meteoWarszawa_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.WarszawaUM();
            SetImage(stream);
            this.Title = "Meteo - Warszawa (UM)";
        }

        private async void meteoWroclaw_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.WroclawUM();
            SetImage(stream);
            this.Title = "Meteo - Wrocław (UM)";
        }

        private async void meteoZielonaGora_Click(object sender, RoutedEventArgs e)
        {
            var stream = await meteo.ZielonaGoraUM();
            SetImage(stream);
            this.Title = "Meteo - Zielona Góra (UM)";
        }

        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
