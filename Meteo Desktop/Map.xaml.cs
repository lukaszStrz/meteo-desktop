using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Meteo_Desktop
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Window
    {
        public Location PinLocation { get; private set; }

        public Map()
        {
            InitializeComponent();
            gridButtons.Background = status.Background;
        }

        private string ParseLatitude(double Value)
        {
            var direction = Value < 0 ? "S" : "N";

            Value = Math.Abs(Value);

            var degrees = Math.Truncate(Value);

            Value = (Value - degrees) * 60;

            var minutes = Math.Truncate(Value);
            var seconds = (Value - minutes) * 60;

            var sb = new StringBuilder();
            sb.Append(degrees);
            sb.Append((char)176);
            sb.Append(minutes);
            sb.Append(@"'");
            sb.Append(seconds);
            sb.Append(@"''");
            sb.Append(direction);
            return sb.ToString();
        }

        private string ParseLongitude(double Value)
        {
            var direction = Value < 0 ? "W" : "E";

            Value = Math.Abs(Value);

            var degrees = Math.Truncate(Value);

            Value = (Value - degrees) * 60;

            var minutes = Math.Truncate(Value);
            var seconds = (Value - minutes) * 60;

            var sb = new StringBuilder();
            sb.Append(degrees);
            sb.Append((char)176);
            sb.Append(minutes);
            sb.Append(@"'");
            sb.Append(seconds);
            sb.Append(@"''");
            sb.Append(direction);
            return sb.ToString();
        }

        private string ParseLocation(Location location)
        {
            var sb = new StringBuilder();
            sb.Append(ParseLatitude(location.Latitude));
            sb.Append(' ');
            sb.Append(ParseLongitude(location.Longitude));
            return sb.ToString();
        }

        private void myMap_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Disables the default mouse double-click action.
            e.Handled = true;

            // Determin the location to place the pushpin at on the map.

            //Get the mouse click coordinates
            Point mousePosition = e.GetPosition(this);
            //Convert the mouse coordinates to a locatoin on the map
            PinLocation = myMap.ViewportPointToLocation(mousePosition);

            // The pushpin to add to the map.
            Pushpin pin = new Pushpin();
            pin.Location = PinLocation;

            // Deletes other pushpins
            myMap.Children.Clear();

            // Adds the pushpin to the map.
            myMap.Children.Add(pin);

            location.Text = ParseLocation(PinLocation);

            cmdOk.IsEnabled = true;
        }

        private void cmdOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
