﻿using System;
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
            var img = new MemoryStream(new WebClient().DownloadData(uri));

            var imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = img;
            imageSource.EndInit();
            imgMeteo.Source = imageSource;
        }

        private void meteoBialystok_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=379&col=285&lang=pl");
        }

        private void meteoBydgoszcz_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=381&col=199&lang=pl");
        }

        private void meteoGdansk_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=346&col=210&lang=pl");
        }

        private void meteoGorzow_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=390&col=152&lang=pl");
        }

        private void meteoKatowice_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=461&col=215&lang=pl");
        }

        private void meteoKielce_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=443&col=244&lang=pl");
        }

        private void meteoKrakow_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=466&col=232&lang=pl");
        }

        private void meteoLublin_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=432&col=277&lang=pl");
        }

        private void meteoLodz_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=418&col=223&lang=pl");
        }

        private void meteoOlsztyn_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=363&col=240&lang=pl");
        }

        private void meteoOpole_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=449&col=196&lang=pl");
        }

        private void meteoPoznan_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=400&col=180&lang=pl");
        }

        private void meteoRzeszow_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=465&col=269&lang=pl");
        }

        private void meteoSzczecin_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=370&col=142&lang=pl");
        }

        private void meteoTorun_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=383&col=209&lang=pl");
        }

        private void meteoWarszawa_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=406&col=250&lang=pl");
        }

        private void meteoWroclaw_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=436&col=181&lang=pl");
        }

        private void meteoZielonaGora_Click(object sender, RoutedEventArgs e)
        {
            setImg(@"http://www.meteo.pl/um/metco/mgram_pict.php?ntype=0u&row=412&col=155&lang=pl");
        }
    }
}
