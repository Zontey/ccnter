using CallCenterApp.Common;
using CallCenterApp.Controllers;
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

namespace CallCenterApp.Views
{
    /// <summary>
    /// Interaction logic for Users.xaml
    /// </summary>
    public partial class Users : Window
    {
        public Users()
        {
            InitializeComponent();

            usersController = new UsersController();
            userController = new UserController(Enums.WindowType.Delete);

            DataContext = usersController;
        }

        public UsersController usersController;

        public UserController userController;

        private User UserWindow;
        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (UserWindow == null)
            {
                UserWindow = new User(Enums.WindowType.Create);
                UserWindow.Show();
                UserWindow.Closed += delegate { UserWindow = null; usersController.RefreshDataGrid(ref dataGrid); };
            }
            UserWindow.Show();
            UserWindow.Activate();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (usersController.SelectedUser != null)
            {
                userController.User = usersController.SelectedUser;
                userController.UserDo();
                usersController.RefreshDataGrid(ref dataGrid);
            }
        }
    }
}
