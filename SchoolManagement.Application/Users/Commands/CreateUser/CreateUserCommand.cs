using AutoMapper;
using SchoolManagement.Application.Helpers;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Application.Users.Queries.GetUser;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly IMapper mapper;
        private readonly IUserData userData;

        public CreateUserCommand(IMapper mapper, IUserData userData)
        {
            this.mapper = mapper;
            this.userData = userData;
        }

        public void CreateUser(CreateUserDto user)
        {
            Guard.EnsureAccountNotExists(userData.GetByLogin(user.Login));

            userData.Insert(mapper.Map<User>(user));
        }
    }
}
