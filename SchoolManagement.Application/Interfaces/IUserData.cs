using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Application.Interfaces
{
    public interface IUserData : ISqlBaseData<User>
    {
        IEnumerable<User> FindAll();
        IEnumerable<User> FindByPartialLogin(string name);
        User GetByLogin(string name);
        User GetById(int userId);
    }
}
