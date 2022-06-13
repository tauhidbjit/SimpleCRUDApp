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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        public static DataGrid dataGrid;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            myDataGrid.ItemsSource = unitOfWork.Members.GetAll();
            dataGrid = myDataGrid;
        }

        private void insertButton_Click(object sender, RoutedEventArgs e)
        {
            InsertPage insertPage = new InsertPage();
            insertPage.ShowDialog();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItem as Member).Id;
            UpdatePage updatePage = new UpdatePage(id);
            updatePage.ShowDialog();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            int id = (myDataGrid.SelectedItem as Member).Id;
            var member = unitOfWork.Members.Get(id);
            unitOfWork.Members.Remove(member);
            unitOfWork.Complete();
            //myDataGrid.ItemsSource = _db.Members.ToList();
        }
    }
}
