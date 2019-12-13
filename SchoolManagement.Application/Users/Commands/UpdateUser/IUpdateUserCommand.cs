using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.UpdateUser
{
    public interface IUpdateUserCommand
    {
        void UpdateUser(UpdateUserDto dto);
    }
}
