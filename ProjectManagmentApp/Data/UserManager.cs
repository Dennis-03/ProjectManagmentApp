﻿using ProjectManagmentApp.Model;
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
        uint id = 1;
        public void AddUser(string userName, string password)
        {
            User addUser = new User
            {
                Password = password,
                UserName = userName,
                Id = id++,
            };

            UserList.Add(addUser);
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
    }
}
