using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterApp.Common;
using CallCenterApp.Models;

namespace CallCenterApp.Services
{
    public class UserService : DbExtensions
    {

        public async Task<List<User>> GetUsers()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return await dbContext.Users.AsNoTracking().ToListAsync();
            }
        }

        public List<User> GetUsersNormal()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return dbContext.Users.AsNoTracking().ToList();
            }
        }

        public async Task<User> GetUser(int userId)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return await dbContext.Users.Where(u => u.UserID == userId).AsNoTracking().FirstOrDefaultAsync();
            }
        }

        public async Task<User> LoginUser(User user)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return await dbContext.Users.Where(u => u.Name == user.Name && u.Password == user.Password).AsNoTracking().FirstOrDefaultAsync();
            }
        }

        public List<User> LoginUserNormal(User user)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                return dbContext.Users.Where(u => u.Name == user.Name && u.Password == user.Password).AsNoTracking().ToList();
            }
        }


        public async Task<User> CreateUser(User user)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                var User = Insert(user, dbContext);
                await dbContext.SaveChangesAsync();
                return User;
            }
        }

        public async void UpdateUser(User user)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Update(user, dbContext);
                await dbContext.SaveChangesAsync();
            }
        }

        public async void DeleteUser(int userId)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Delete(new User {UserID = userId}, dbContext);
                await dbContext.SaveChangesAsync();
            }
        }

        public async void DeleteUser(User user)
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Delete(new User { UserID = user.UserID }, dbContext);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
