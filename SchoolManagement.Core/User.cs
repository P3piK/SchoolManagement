using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public class User //: IValidatableObject
    {
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Login { get; set; }
        public UserType UserType { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
    }
}
