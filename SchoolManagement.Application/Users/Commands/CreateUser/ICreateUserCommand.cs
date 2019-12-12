using SchoolManagement.Application.Users.Queries.GetUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.CreateUser
{
    public interface ICreateUserCommand
    {
        void CreateUser(CreateUserDto user);
    }
}
