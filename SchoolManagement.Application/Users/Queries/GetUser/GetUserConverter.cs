using AutoMapper;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Queries.GetUser
{
    public class GetUserConverter : ITypeConverter<User, GetUserDto>
    {
        public GetUserDto Convert(User source, GetUserDto destination, ResolutionContext context)
        {
            destination = new GetUserDto();

            destination.Address = source.Address;
            destination.Address = source.Address;
            destination.BirthDate = source.BirthDate;
            destination.Login = source.Login;
            destination.Name = source.Name;
            destination.Phone = source.Phone;
            destination.Status = (Enums.UserStatus)source.StatusCode;
            destination.UserType = (Enums.UserType)source.UserTypeCode;

            return destination;
        }
    }
}
