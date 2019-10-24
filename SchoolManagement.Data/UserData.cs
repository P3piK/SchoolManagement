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

        public int Commit()
        {
            return Context.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return Context.Users;
        }

        public User GetById(int userId)
        {
            return Context.Users.Find(userId);
        }

        public IEnumerable<User> GetByLogin(string name)
        {
            return from u in Context.Users
                   where u.Name.Contains(name) || String.IsNullOrEmpty(name)
                   select u;
        }

        public User Insert(User user)
        {
            var entry = Context.Users.Add(user);
            entry.State = EntityState.Added;

            return user;
        }

        public User Remove(int id)
        {
            var user = GetById(id);
            if (user != null)
            {
                var entry = Context.Users.Remove(user);
                entry.State = EntityState.Deleted;
            }

            return user;
        }

        public User Update(User user)
        {
            var entry = Context.Users.Attach(user);
            entry.State = EntityState.Modified;

            return user;
        }
    }
}
