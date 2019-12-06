using SchoolManagement.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Interfaces
{
    public interface IAdministrationCommand
    {
        UserDto AddUser(UserDto user);
        IEnumerable<UserDto> GetAllUsers();
    }
}
