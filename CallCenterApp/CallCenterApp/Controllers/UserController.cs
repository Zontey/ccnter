using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using CallCenterApp.Services;
using CallCenterApp.Models;
using CallCenterApp.Common;
using System.Runtime.InteropServices;

namespace CallCenterApp.Controllers
{
    public class UserController
    {
        public UserController([Optional] Enums.WindowType windowType)
        {
            this.windowType = windowType;
            userService = new UserService();
        }

        #region Variables

        private UserService userService;

        private User user = new User();
        public User User
        {
            get { return user; }
            set { user = value; }
        }
        #endregion



        public bool Login(string password)
        {
            user.Password = password;
            var result = userService.LoginUser(user).Result;
            if (result != null)
            {
                SessionController.User = new User
                {
                    IsAdmin = result.IsAdmin,
                    UserID = result.UserID,
                    Name = result.Name,
                    Description = result.Description
                };
                return true;
            }
            else
                return false;
        }

        private Enums.WindowType windowType;
        public bool UserDo([Optional] string password)
        {
            if (windowType == Enums.WindowType.Create)
            {
                User.Password = password;
                return userService.CreateUser(User).Result.UserID > 0 ? true : false;
                //return true;
            }
            else if (windowType == Enums.WindowType.Delete)
            {
                userService.DeleteUser(User.UserID);
                return true;
            }
            return true;
        }
    }
}
