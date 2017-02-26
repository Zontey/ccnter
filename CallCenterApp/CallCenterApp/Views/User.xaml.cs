using CallCenterApp.Common;
using CallCenterApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace CallCenterApp.Views
{
    /// <summary>
    /// Interaction logic for User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User(Enums.WindowType windowType)
        {
            InitializeComponent();

            userController = new UserController(windowType);

            DataContext = userController;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (userController.UserDo(passwordBoxPassword.Password)) Close();
        }


        public UserController userController = new UserController();
    }
}
