using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace comn
{
    /// <summary>
    /// Логика взаимодействия для AppUser.xaml
    /// </summary>
    public partial class AppUser : Page
    {
        private User _currentUser = new User();
        public AppUser(User selectUser)
        {
            
            if (selectUser!=null)
            {
                _currentUser = selectUser;
            }
            InitializeComponent();
            DataContext = _currentUser;
           RoleInput.ItemsSource = App.DB.Role.ToList();
        }

        private void BAddData_Click(object sender, RoutedEventArgs e)
        {
            
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentUser.Name))
            {
                errors.Append("Укажите свое имя");
            }
            if (_currentUser.RoleId == -1)
            {
                errors.Append("Not role " + _currentUser.RoleId + RoleInput.SelectedItem+ " "+ RoleInput.SelectedIndex);
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (RoleInput.SelectedIndex > -1)
            {
                _currentUser.RoleId=RoleInput.SelectedIndex+1; 
                
                App.DB.User.Add(_currentUser);

                try
                {
                    App.DB.SaveChanges();
                    Maneger.MainFrame.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }




        }

       
       
    }
}
