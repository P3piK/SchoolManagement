using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagement.Application.Users.Dto
{
    public enum UserType
    {
        None = 0,
        Admin = 1,
        Superuser = 2,
        Teacher = 3,
        Student = 4,
    }

    public enum UserStatus
    {
        Active = 0,
        Inactive = 1,
        PasswordReset = 2,
    }

    public class UserDto
    {
        [Required, EmailAddress]
        public string Login { get; set; }
        public UserType UserType {get;set;}
        public UserStatus Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
