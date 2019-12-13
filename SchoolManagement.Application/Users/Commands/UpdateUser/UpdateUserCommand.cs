using AutoMapper;
using SchoolManagement.Application.Helpers;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly IMapper mapper;
        private readonly IUserData userData;

        public UpdateUserCommand(IMapper mapper, IUserData userData)
        {
            this.mapper = mapper;
            this.userData = userData;
        }

        public void UpdateUser(UpdateUserDto dto)
        {
            var user = userData.GetByLogin(dto.Login);
            Guard.EnsureAccountExists(user, dto.Login);
            Guard.EnsureAccountNotExists(userData.GetByLogin(dto.NewLogin));

            user = mapper.Map(dto, user);
            userData.Update(user);
        }
    }
}
