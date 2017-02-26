using CallCenterApp.Models;
using CallCenterApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CallCenterApp.Controllers
{
    public class UsersController
    {
        private User selectedUser = new User();
        public User SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; }
        }

        private List<User> users = new List<User>();
        public List<User> Users
        {
            get { return users; }
        }



        private UserService userService;

        public UsersController()
        {
            userService = new UserService();

            GetUsers();
        }

        public void GetUsers()
        {
            users = userService.GetUsers().Result;
        }


        public void RefreshDataGrid(ref DataGrid dataGrid)
        {
            GetUsers();
            dataGrid.ItemsSource = users;
        }
    }
}
