using ProjectManagmentApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Data
{
    class UserManager
    {
        private static readonly UserManager _instance = new UserManager();
        private UserManager()
        {
        }
        public static UserManager GetUserManager()
        {
            return _instance;
        }

        List<User> UserList = new List<User>();
        long id = 1;
        public bool AddUser(string userName, string password)
        {
            User existingUser = UserList.Find(user => user.UserName == userName);
            if (existingUser != null)
            {
                return false;
            }

            User addUser = new User
            {
                Password = password,
                UserName = userName,
                Id = id++,
            };
            UserList.Add(addUser);
            return true;
        }

        public User VerifyUser(string userName, string password)
        {
            foreach (var user in UserList)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
        public User GetUser(long Id)
        {
            return UserList.Find(user => user.Id == Id);
        }
        public List<User> GetAllUsers()
        {
            return UserList;
        }
    }
}
