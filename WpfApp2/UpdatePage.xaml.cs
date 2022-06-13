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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
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
            member = (from m in unitOfWork.Members.GetAll()
                      where m.Id == _id
                      select m).Single();

            nameTextBox.Text = member.Name;
            genderComboBox.SelectedIndex = (member.Gender.Trim() == "Male" ? 0 : 1);
            //if(member.Gender.Trim() == "Male")
            //{

            //}
            //else
            //{

            //}

        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            Member member = new Member();
            member = (from m in unitOfWork.Members.GetAll()
                     where m.Id == _id
                     select m).Single();

            member.Name = nameTextBox.Text;
            member.Gender = genderComboBox.Text;
            unitOfWork.Complete();
            
            this.Close();
            Load();
        }

        private void Load()
        {
            var data = unitOfWork.Members;
            //AppEntities appEntities = new AppEntities();

            MainWindow.dataGrid.ItemsSource = unitOfWork.Members.GetAll();
            //MainWindow.dataGrid.ItemsSource = appEntities.Members.ToList();
        }
    }
}
