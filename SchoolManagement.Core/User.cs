using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Core
{
    public enum UserType
    {
        None = 0,
        Admin = 1,
        Superuser = 2,
        Teacher = 3,
        Student = 4,
    }

    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public UserType UserType { get; set; }
        public string Name { get; set; }
    }
}
