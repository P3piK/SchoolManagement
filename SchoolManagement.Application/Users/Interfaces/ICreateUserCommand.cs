using SchoolManagement.Application.Users.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Interfaces
{
    public interface ICreateUserCommand
    {
        UserDto AddUser(UserDto user);
    }
}
