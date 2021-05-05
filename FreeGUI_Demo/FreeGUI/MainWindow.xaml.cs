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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FreeGUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_Berechnung_Click(object sender, RoutedEventArgs e)
        {
            // Berechnung durchführen
        }

        private void tb_ArtNr_LostFocus(object sender, RoutedEventArgs e)
        {
            //Überprüfungen
            TextBox tb = (TextBox)sender;

            Double res;

            if (Double.TryParse(tb.Text, out res))
            {
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                tb.Background = Brushes.OrangeRed;
            }

        }

        private void tvi_SubBG_Selected(object sender, RoutedEventArgs e)
        {
            TreeViewItem tvi = (TreeViewItem) sender;
            tvi.Header = "Sub BG Test";
        }
    }
}
