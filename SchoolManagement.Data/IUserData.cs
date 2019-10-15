using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Data
{
    public interface IUserData
    {
        IEnumerable<User> GetAllUsers();
    }

    public class InMemoryUserData : IUserData
    {
        IEnumerable<User> Users { get; set; }

        public InMemoryUserData()
        {
            Users = new List<User>()
            {
                new User { Id = 0, Login = "pete@nasa.com", UserType = UserType.Admin },
                new User { Id = 1, Login = "eva@nasa.com", UserType = UserType.Teacher },
                new User { Id = 2, Login = "john@nasa.com", UserType = UserType.Student }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Users;
        }
    }
}
