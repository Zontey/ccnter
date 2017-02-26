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
using CallCenterApp.Controllers;
using CallCenterApp.Views;

namespace CallCenterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            userController = new UserController();
            InitializeComponent();

            DataContext = userController;

            using (var context = new ApplicationDbContext())
            {
                context.Database.Initialize(false);
            }
        }

        UserController userController;

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            if (userController.Login(passwordBox.Password))
            {
                new CallCenterWindow().Show();
                this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wpisano błędny login lub hasło.");
            }
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
                if (userController.Login(passwordBox.Password))
                {
                    new CallCenterWindow().Show();
                    this.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wpisano błędny login lub hasło.");
                }
                Mouse.OverrideCursor = System.Windows.Input.Cursors.Arrow;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Keyboard.Focus(textBoxLogin);
        }
    }
}
