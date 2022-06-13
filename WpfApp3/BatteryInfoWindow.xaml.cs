using DAL;
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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for BatteryInfoWindow.xaml
    /// </summary>
    public partial class BatteryInfoWindow : Window
    {
        public BatteryInfoWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            //var data = UnitOfWork.Batteries;
            //batteryInfoGrid.ItemsSource = UnitOfWork.Batteries.GetAll();
            //dataGrid = myDataGrid;
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int id = (batteryInfoGrid.SelectedItem as Battery).Id;

        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
