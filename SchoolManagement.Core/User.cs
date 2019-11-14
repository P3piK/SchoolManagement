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
        [Key]
        public int Id { get; set; }

        [Key, StringLength(80), EmailAddress]
        public string Login { get; set; }

        public UserType UserType { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Timestamp]
        public DateTime BirthDate { get; set; }
    }
}
