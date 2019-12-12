using SchoolManagement.Application.Users.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagement.Application.Users.Queries.GetUser
{
    public class GetUserDto
    {
        public string Login { get; set; }
        public UserType? UserType {get;set;}
        public UserStatus? Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
