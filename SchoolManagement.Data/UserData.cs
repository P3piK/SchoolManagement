using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Core;

namespace SchoolManagement.Data
{
    public class UserData : IUserData
    {

        public UserData(SmContext context)
        {
            this.Context = context;
        }

        public SmContext Context { get; }

        #region SQL Base Methods

        public int Commit()
        {
            return Context.SaveChanges();
        }

        public User Insert(User user)
        {
            user.SetupSystemFields();
            var entry = Context.Users.Add(user);
            entry.State = EntityState.Added;

            return user;
        }

        public User Update(User user)
        {
            user.SetupSystemFields();
            var entry = Context.Users.Attach(user);
            entry.State = EntityState.Modified;

            return user;
        }

        #endregion

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
            return Context.Users.Where(u => u.Name.Contains(searchTerm) || u.Login.Contains(searchTerm) || String.IsNullOrEmpty(searchTerm));
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
