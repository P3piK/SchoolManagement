using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Exceptions
{
    public class AccountNotExistsException : Exception
    {
        public AccountNotExistsException(int id)
            : base(String.Format("Account not exists for id: {0}", id))
        {
        }

        public AccountNotExistsException(string login)
            : base(String.Format("Account not exists for login: {0}", login))
        {
        }
    }
}
