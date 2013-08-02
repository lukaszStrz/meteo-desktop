using System.Windows;

namespace Meteo_Desktop
{
    /// <summary>
    /// Interaction logic for SaveFav.xaml
    /// </summary>
    public partial class SaveFav : Window
    {
        public string Key { get; private set; }

        public SaveFav()
        {
            InitializeComponent();
        }

        private void cmdOk_Click(object sender, RoutedEventArgs e)
        {
            Key = txtKey.Text;
            this.DialogResult = true;
        }

        private void txtKey_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            cmdOk.IsEnabled = !string.IsNullOrWhiteSpace(txtKey.Text);
        }
    }
}
