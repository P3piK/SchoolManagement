using SchoolManagement.Application.Services;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Persistance.Data
{
    public class UserData : SqlBaseData<User>, IUserData
    {

        public UserData(SmContext context)
            : base(context)
        {
        }

        #region Public Methods

        public IEnumerable<User> FindAll()
        {
            return Context.Users;
        }

        public User GetById(int userId)
        {
            return Context.Users.Find(userId);
        }

        public IEnumerable<User> FindByPartialLogin(string searchTerm)
        {
            return Context.Users
                .Where(u => u.Name.Contains(searchTerm) || u.Login.Contains(searchTerm) || String.IsNullOrEmpty(searchTerm));
        }

        public User GetByLogin(string login)
        {
            return Context.Users.Where(u => u.Login.Equals(login)).SingleOrDefault();
        }

        #endregion

        #region Private



        #endregion
    }
}
