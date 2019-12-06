using SchoolManagement.Application.Dto;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Commands
{
    public class AdministrationCommand : IAdministrationCommand
    {
        private readonly IUserData userData;
        //private readonly IMapper mapper;

        public AdministrationCommand(IUserData userData)
        {
            this.userData = userData;
        }

        public UserDto AddUser(UserDto user)
        {;
            //return userData.Insert(user);
            return null;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            //return userData.FindAll();
            return null;
        }
    }
}
