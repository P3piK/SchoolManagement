using SchoolManagement.Application.Users.Exceptions;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Helpers
{
    public static class Guard
    {
        public static void EnsureAccountNotExists(User user)
        {
            if (user != null)
            {
                throw new AccountExistsException(user.Login);
            }
        }

        public static void EnsureAccountExists(User user, string login)
        {
            if (user == null)
            {
                throw new AccountNotExistsException(login);
            }
        }

        //public static void EnsureLoginExists()
    }
}
