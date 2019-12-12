using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Exceptions
{
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException(string login)
            : base(String.Format("Invalid Login: {0}", login))
        {
        }
    }
}
