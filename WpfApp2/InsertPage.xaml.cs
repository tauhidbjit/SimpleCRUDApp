using System;
using System.Linq;
using System.Windows;
using DAL;
using AppContext = DAL.AppContext;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

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

            unitOfWork.Members.Add(member);
            unitOfWork.Complete();
            this.Close();
            Load();
        }

        private void Load()
        {
            //var data = unitOfWork.Members;
            //AppEntities appEntities = new AppEntities();

            MainWindow.dataGrid.ItemsSource = unitOfWork.Members.GetAll();
            //MainWindow.dataGrid.ItemsSource = appEntities.Members.ToList();
        }
    }
}
