using AutoMapper;
using SchoolManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Application.Users.Queries.GetUser
{
    public class GetUserQuery : IGetUserQuery
    {
        private readonly IUserData userData;
        private readonly IMapper mapper;

        public GetUserQuery(IUserData userData, IMapper mapper)
        {
            this.userData = userData;
            this.mapper = mapper;
        }

        public IEnumerable<GetUserDto> GetAllUsers()
        {
            var users = userData.FindAll();

            return mapper.Map<IEnumerable<GetUserDto>>(users);
        }

        public GetUserDto GetByLogin(string login)
        {
            var user = userData.GetByLogin(login);

            return mapper.Map<GetUserDto>(user);
        }
    }
}
