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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        SimpleWPFAppEntities1 _db = new SimpleWPFAppEntities1();
        public InsertPage()
        {
            InitializeComponent();
        }

        private void insertButton_Click_1(object sender, RoutedEventArgs e)
        {
            Member member = new Member()
            {
                Name = nameTextBox.Text,
                Gender = genderComboBox.Text
            };

            _db.Members.Add(member);
            _db.SaveChanges();
            MainWindow.dataGrid.ItemsSource = _db.Members.ToList();
            this.Close();
        }
    }
}
