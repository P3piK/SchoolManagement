using SchoolManagement.Application.Interfaces;
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

        public User GetByTutorId(int tutorId)
        {
            return Context.Users.Where(u => u.TutorId == tutorId).SingleOrDefault();
        }

        public int GetMaxTutorId()
        {
            return Context.Users.Max(u => u.TutorId) ?? 0;
        }

        #endregion

        #region Private



        #endregion
    }
}
