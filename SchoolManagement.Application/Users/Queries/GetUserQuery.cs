using SchoolManagement.Application.Users.Dto;
using SchoolManagement.Application.Users.Interfaces;
using SchoolManagement.Application.Users.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Application.Users.Queries
{
    public class GetUserQuery : IGetUserQuery
    {
        private readonly IUserData userData;
        //private readonly IMapper mapper;

        public GetUserQuery(IUserData userData)
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
            var users = userData.FindAll()
                .Select(u => new UserDto()
                {
                    Login = u.Login,
                    UserType = (UserType)u.UserTypeCode,
                    Status = (UserStatus)u.StatusCode,
                    Name = u.Name,
                    Phone = u.Phone,
                    Address = u.Address,
                    BirthDate = u.BirthDate,
                });

            return users;
        }
    }
}
