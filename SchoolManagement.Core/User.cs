using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Core
{
    public enum UserType
    {
        Admin = 0,
        Superuser = 1,
        Teacher = 2,
        Student = 3,
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public UserType UserType { get; set; }
    }
}
