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

        public void CreateUser(CreateUserDto userDto)
        {
            Guard.EnsureAccountNotExists(userData.GetByLogin(userDto.Login));
            var user = mapper.Map<User>(userDto);

            // TODO:
            // Refactor to Factory Pattern
            if (user.UserTypeCode == UserType.Teacher)
            {
                user.TutorId = userData.GetMaxTutorId() + 1;
            }
            /////////////

            userData.Insert(user);
        }
    }
}
