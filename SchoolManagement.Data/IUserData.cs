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
        User Insert(User user);
        User Update(User user);
        User Remove(int id);
        int Commit();
    }
}
