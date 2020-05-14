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

namespace HelloGUI_VL
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int ii = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Environment.Exit(0);
            Application.Current.Shutdown();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button exitButton = (Button) sender;
            exitButton.Content = "Hohoho";
        }

        private void btn_MachWas_Click(object sender, RoutedEventArgs e)
        {
            lab_helloLabel.Content = "Gemacht! " + ii;
            ii++;
            Double res = 0;
            String text = tb_Summand.Text;
            if (Double.TryParse(text, out res))
            {
                MessageBox.Show("Super " +res , "GUT");
            }
            else
            {
                MessageBox.Show("Bitte Zahl eingeben..", "Schlecht");
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbi_leder_Selected(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)sender;
            lab_helloLabel.Content = cbi.Content;
        }

        private void cbi_kunststoff_Selected(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)sender;
            lab_helloLabel.Content = cbi.Content;
        }

        private void tvi_MB_Selected(object sender, RoutedEventArgs e)
        {
            gird_MB.Visibility = Visibility.Visible;
            gird_Meer.Visibility = Visibility.Hidden;
        }

        private void tvi_Meer_Selected(object sender, RoutedEventArgs e)
        {
            gird_MB.Visibility = Visibility.Hidden;
            gird_Meer.Visibility = Visibility.Visible;
        }
    }
}
