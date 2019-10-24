using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Data
{
    public class InMemoryUserData : IUserData
    {
        readonly List<User> users;

        public InMemoryUserData()
        {
            users = new List<User>()
            {
                new User { Id = 0, Login = "pete@nasa.com", UserType = UserType.Admin, Name = "Pete" },
                new User { Id = 1, Login = "eva@nasa.com", UserType = UserType.Teacher, Name = "Eva B" },
                new User { Id = 2, Login = "john@nasa.com", UserType = UserType.Student, Name = "John Kovalsky" }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }

        public IEnumerable<User> GetByLogin(string name)
        {
            return users.Where(u => String.IsNullOrEmpty(name) || u.Login.Contains(name));
        }

        public User GetById(int userId)
        {
            return users.SingleOrDefault(u => u.Id == userId);
        }

        public User Insert(User newUser)
        {
            newUser.Id = users.Max(u => u.Id) + 1;
            users.Add(newUser);

            return newUser;
        }

        public User Update(User updatedUser)
        {
            var user = users.SingleOrDefault(u => u.Id == updatedUser.Id);

            if (user != null)
            {
                user.Login = updatedUser.Login;
                user.Name = updatedUser.Name;
                user.UserType = updatedUser.UserType;
            }

            return user;
        }

        public User Remove(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
            }

            return user;
        }

        public int Commit()
        {
            return 0;
        }
    }

}
