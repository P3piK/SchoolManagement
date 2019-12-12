using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Queries.GetUser
{
    public interface IGetUserQuery
    {
        IEnumerable<GetUserDto> GetAllUsers();
        GetUserDto GetByLogin(string login);
    }
}
