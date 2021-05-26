using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        Label lab_newLabel = new Label();
        int ii = 1;

        public MainWindow()
        {

            DataContext = this;

            InitializeComponent();

            lab_newLabel.Content = "Test123";
            lab_newLabel.Width = 150;
            lab_newLabel.VerticalAlignment = VerticalAlignment.Bottom;
            lab_newLabel.HorizontalAlignment = HorizontalAlignment.Left;
            lab_newLabel.Margin = new Thickness(20);
            lab_newLabel.Visibility = Visibility.Visible;
            mainGrid.Children.Add(lab_newLabel);


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

        private int _sliderZahl;

        public int SliderZahl
        {
            get { return _sliderZahl; }
            set { 
                if(_sliderZahl != value)
                {
                    _sliderZahl = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyname = null )
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


        private void tb_NoBinding2_TextChanged(object sender, TextChangedEventArgs e)
        {
            double value;
            TextBox tb = (TextBox)sender;
            if (Double.TryParse((tb).Text, out value))
            {
                tb.Background = Brushes.LightGreen;
                if (slider_NoBinding2 != null)
                {
                    slider_NoBinding2.Value = value;
                }
            }
            else
            {
                tb.Background = Brushes.OrangeRed;
            }
        }

        private void slider_NoBinding2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tb_NoBinding2.Text = ((Slider)sender).Value + "";
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Create a List of objects.
            var items = new List<Dog>();
            items.Add(new Dog("Fido", 10));
            items.Add(new Dog("Spark", 20));
            items.Add(new Dog("Fluffy", 4));

            // ... Assign ItemsSource of DataGrid.
            var grid = sender as DataGrid;
            grid.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lab_newLabel.Content = "Click";
        }

        private void btn_addItem_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem item = new ComboBoxItem();
            item.Content = "item " + ii;
            cb_newCBox.Items.Add(item);
            ii++;
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)
        {
            
        }

        private void tvi_BG2_Selected(object sender, RoutedEventArgs e)
        {
            hideAllGrids();
            grid_BG2.Visibility = Visibility.Visible;
        }

        private void tvi_BG3_Selected(object sender, RoutedEventArgs e)
        {
            hideAllGrids();
            grid_BG3.Visibility = Visibility.Visible;
        }

        private void tvi_BG4_Selected(object sender, RoutedEventArgs e)
        {
            hideAllGrids();
        }

        private void hideAllGrids()
        {
            grid_BG2.Visibility = Visibility.Hidden;
            grid_BG3.Visibility = Visibility.Hidden;
        }

    }

}
