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

namespace Student_GUI
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

        /// <summary>
        /// Callback Funktion des Exit Knopf
        /// </summary>
        /// <param name="sender">Referenz zu dem Objekt, welches die Funktion aufgerufen hat.</param>
        /// <param name="e">Informatoinen zu dem Event (Ereignis), welches Begerade bearbeitet wird.</param>
        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Callback Funktion des treeview Items Student => MB
        /// </summary>
        /// <param name="sender">Referenz zu dem Objekt, welches die Funktion aufgerufen hat.</param>
        /// <param name="e">Informatoinen zu dem Event (Ereignis), welches Begerade bearbeitet wird.</param>
        private void tvi_MB_Selected(object sender, RoutedEventArgs e)
        {
            // Schaltet die Sichtbarkeit des MB Grid an und Meer ab
            grid_MB.Visibility = Visibility.Visible;
            grid_meer.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Callback Funktion des treeview Items Student => Meer
        /// </summary>
        /// <param name="sender">Referenz zu dem Objekt, welches die Funktion aufgerufen hat.</param>
        /// <param name="e">Informatoinen zu dem Event (Ereignis), welches Begerade bearbeitet wird.</param>
        private void tvi_meer_Selected(object sender, RoutedEventArgs e)
        {
            // Schaltet die Sichtbarkeit des Meer Grid an und MB ab
            grid_MB.Visibility = Visibility.Hidden;
            grid_meer.Visibility = Visibility.Visible;

            // Mit dieser Type Umwandlung machen wir das sender - Objekt als TreeViewItem-Objekt nutzbar:
            TreeViewItem tvi = (TreeViewItem)sender;

            // Nun können wir auf die "Header" Eigenschaft des tvi zugreifen und über das Test Label (lab_testLabel) ausgeben:
            lab_testLabel.Content = tvi.Header;
        }

        /// <summary>
        /// Callback Funktion des Berechne-Knopf.
        /// In diesem Fall wird zum Test ein Label (lab_testLabel) mit dem treeViewItem Text (header) gefüllt.
        /// </summary>
        /// <param name="sender">Referenz zu dem Objekt, welches die Funktion aufgerufen hat.</param>
        /// <param name="e">Informatoinen zu dem Event (Ereignis), welches Begerade bearbeitet wird.</param>
        private void btn_Berechne_Click(object sender, RoutedEventArgs e)
        {
            // Mit dieser Type Umwandlung machen wir das TreeViewItem als Objekt nutzbar:
            TreeViewItem tviSelected = (TreeViewItem)trv_Auswahl.SelectedItem;

            // Nun können wir auf die "Header" Eigenschaft des tvi zugreifen und über das Test Label (lab_testLabel) ausgeben:
            lab_testLabel.Content = tviSelected.Header;
        }

        private void tb_schuhgr_LostFocus(object sender, RoutedEventArgs e)
        {
            Double result = getNumericValue(sender);
        }

        private void tb_schuhgr_KeyDown(object sender, KeyEventArgs e)
        {
            /// if enter gedrückt
            Double result = getNumericValue(sender);
        }

        private double getNumericValue(object sender)
        {
            TextBox tb = (TextBox)sender;
            String text = tb.Text;

            Double res;
            Double.TryParse(text, out res);
            if (Double.TryParse(text, out res))
            {
                // alles gut
                tb.Background = Brushes.LightGreen;
            }
            else
            {
                // Kein Zahl - Problem
                tb.Background = Brushes.OrangeRed;
                // MessageBox.Show("Keine Zahl - bitte neue Eingabe: " + text);
            }
            return res;
        }

        private void ComboBoxItem_Selected_Leder(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)sender;
            lab_testLabel.Content = cbi.Content;
        }

        private void ComboBoxItem_Selected_Kunststoff(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)sender;
            lab_testLabel.Content = cbi.Content;
//            ComboBoxItem cbi = (ComboBoxItem) cd_Material.SelectedItem;
//            lab_testLabel.Content = cbi.Content;
        }
    }
}
