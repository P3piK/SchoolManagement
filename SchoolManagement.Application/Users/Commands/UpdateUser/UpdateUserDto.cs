using SchoolManagement.Application.Users.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.UpdateUser
{
    public class UpdateUserDto
    {
        [Required, EmailAddress]
        public string Login { get; set; }
        [EmailAddress]
        public string NewLogin { get; set; }
        [Required]
        public UserType? UserType { get; set; }
        [Required]
        public UserStatus? Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Phone]
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
