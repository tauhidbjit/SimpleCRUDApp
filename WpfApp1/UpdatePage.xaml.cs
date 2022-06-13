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
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        SimpleWPFAppEntities1 _db = new SimpleWPFAppEntities1();
        int _id;
        public UpdatePage(int memberId)
        {
            InitializeComponent();
            _id = memberId;
            LoadData();
        }

        private void LoadData()
        {
            Member member = new Member();
            member = (from m in _db.Members
                      where m.Id == _id
                      select m).Single();

            nameTextBox.Text = member.Name;
            genderComboBox.Text = member.Gender;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member();
            member = (from m in _db.Members
                     where m.Id == _id
                     select m).Single();

            member.Name = nameTextBox.Text;
            member.Gender = genderComboBox.Text;
            _db.SaveChanges();
            
            MainWindow.dataGrid.ItemsSource = _db.Members.ToList();
            this.Close();
        }
    }
}
