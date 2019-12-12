using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Exceptions
{
    public class AccountNotExistsException : Exception
    {
        public AccountNotExistsException(string login)
            : base(String.Format("Account not exists for login: {0}", login))
        {
        }
    }
}
