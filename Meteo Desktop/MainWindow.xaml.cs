using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

        void setImg(string uri)
        {
            try
            {
                var img = new MemoryStream(new WebClient().DownloadData(uri));
                var imageSource = new BitmapImage();
                imageSource.BeginInit();
                imageSource.StreamSource = img;
                imageSource.EndInit();
                imgMeteo.Source = imageSource;
            }
            catch
            {
                MessageBox.Show(this, "Sprawdź połączenie internetowe", "Błąd pobierania", MessageBoxButton.OK, MessageBoxImage.Error);
                imgMeteo.Source = null;
            }
        }

        #region Main Cities

        private void meteoBialystok_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=379&col=285&lang=pl");
            this.Title = "Meteo - Białystok (UM)";
        }

        private void meteoBydgoszcz_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=381&col=199&lang=pl");
            this.Title = "Meteo - Bydgoszcz (UM)";
        }

        private void meteoGdansk_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=346&col=210&lang=pl");
            this.Title = "Meteo - Gdańsk (UM)";
        }

        private void meteoGorzow_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=390&col=152&lang=pl");
            this.Title = "Meteo - Gorzów Wielkopolski (UM)";
        }

        private void meteoKatowice_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=461&col=215&lang=pl");
            this.Title = "Meteo - Katowice (UM)";
        }

        private void meteoKielce_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=443&col=244&lang=pl");
            this.Title = "Meteo - Kielce (UM)";
        }

        private void meteoKrakow_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=466&col=232&lang=pl");
            this.Title = "Meteo - Kraków (UM)";
        }

        private void meteoLublin_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=432&col=277&lang=pl");
            this.Title = "Meteo - Lublin (UM)";
        }

        private void meteoLodz_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=418&col=223&lang=pl");
            this.Title = "Meteo - Łódź (UM)";
        }

        private void meteoOlsztyn_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=363&col=240&lang=pl");
            this.Title = "Meteo - Olsztyn (UM)";
        }

        private void meteoOpole_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=449&col=196&lang=pl");
            this.Title = "Meteo - Opole (UM)";
        }

        private void meteoPoznan_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=400&col=180&lang=pl");
            this.Title = "Meteo - Poznań (UM)";
        }

        private void meteoRzeszow_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=465&col=269&lang=pl");
            this.Title = "Meteo - Rzeszów (UM)";
        }

        private void meteoSzczecin_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=370&col=142&lang=pl");
            this.Title = "Meteo - Szczecin (UM)";
        }

        private void meteoTorun_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=383&col=209&lang=pl");
            this.Title = "Meteo - Toruń (UM)";
        }

        private void meteoWarszawa_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=406&col=250&lang=pl");
            this.Title = "Meteo - Warszawa (UM)";
        }

        private void meteoWroclaw_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=436&col=181&lang=pl");
            this.Title = "Meteo - Wrocław (UM)";
        }

        private void meteoZielonaGora_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=412&col=155&lang=pl");
            this.Title = "Meteo - Zielona Góra (UM)";
        }

        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
