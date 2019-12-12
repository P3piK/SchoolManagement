using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Exceptions
{
    public class AccountExistsException : Exception
    {
        public AccountExistsException(string login)
            : base(String.Format("Account exists for login: {0}", login))
        {
        }
    }
}
