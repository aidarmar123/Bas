using comn.Models;
using comn.Script;
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

namespace comn.Script
{
    /// <summary>
    /// Логика взаимодействия для AllUsersxaml.xaml
    /// </summary>
    public partial class AllUsersxaml : Page
    {
        public AllUsersxaml()
        {
            InitializeComponent();
            DGUsers.ItemsSource = App.DB.User.ToList();
        }
        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            Maneger.MainFrame.Navigate(new AppUser(null));
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            
            
                if (DGUsers.SelectedItem is User user)
                {
                    App.DB.User.Remove(user);
                    try
                    {
                        App.DB.SaveChanges();
                    }
                    catch
                    {
                        MessageBox.Show("Data not save");
                    }
                Maneger.MainFrame.Navigate(new AppUser(DGUsers.SelectedItem as User));
                Refresh();
                }
                
        
        }

        private void BRemove_Click(object sender, RoutedEventArgs e)
        {
            if (DGUsers.SelectedItem is User user)
            {
                App.DB.User.Remove(user);
                try
                {
                    App.DB.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Data not save");
                }
                
                Refresh();
            }
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
        

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Refresh();
            }
        }
        private void Refresh()
        {
            DGUsers.ItemsSource = App.DB.User.ToList();
        }
    }
}
