using SchoolManagement.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Data
{
    public interface IUserData
    {
        IEnumerable<User> FindAll();
        IEnumerable<User> FindByPartialLogin(string name);
        User GetByLogin(string name);
        User GetById(int userId);
        User Insert(User user);
        User Update(User user);
        int Commit();
    }
}
