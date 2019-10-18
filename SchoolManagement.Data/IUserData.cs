using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Data
{
    public interface IUserData
    {
        IEnumerable<User> GetAllUsers();
        IEnumerable<User> GetByLogin(string name);
        User GetById(int userId);
        User Update(User user);
        int Commit();
    }

    public class InMemoryUserData : IUserData
    {
        IEnumerable<User> Users { get; set; }

        public InMemoryUserData()
        {
            Users = new List<User>()
            {
                new User { Id = 0, Login = "pete@nasa.com", UserType = UserType.Admin, Name = "Pete" },
                new User { Id = 1, Login = "eva@nasa.com", UserType = UserType.Teacher, Name = "Eva B" },
                new User { Id = 2, Login = "john@nasa.com", UserType = UserType.Student, Name = "John Kovalsky" }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }

        public IEnumerable<User> GetByLogin(string name)
        {
            return Users.Where(u => String.IsNullOrEmpty(name) || u.Login.Contains(name));
        }

        public User GetById(int userId)
        {
            return Users.SingleOrDefault(u => u.Id == userId);
        }

        public User Update(User updatedUser)
        {
            var user = Users.SingleOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                user = updatedUser;
            }

            return user;
        }

        public int Commit()
        {
            return 0;
        }
    }
}
