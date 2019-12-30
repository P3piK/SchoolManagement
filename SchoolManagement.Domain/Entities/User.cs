using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Domain.Entities
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

    public class User : EntityBase
    {
        public string Login { get; set; }
        public UserType UserTypeCode { get; set; }
        public UserStatus StatusCode { get; set; }
        public int? StudentId { get; set; }
        public int? TutorId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }

    }
}
