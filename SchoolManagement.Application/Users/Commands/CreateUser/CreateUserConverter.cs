using AutoMapper;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.CreateUser
{
    public class CreateUserConverter : ITypeConverter<CreateUserDto, User>
    {
        public User Convert(CreateUserDto source, User destination, ResolutionContext context)
        {
            destination = new User();

            destination.Address = source.Address;
            destination.BirthDate = source.BirthDate;
            destination.Login = source.Login;
            destination.Name = source.Name;
            destination.Phone = source.Phone;
            destination.StatusCode = (UserStatus)source.Status;
            destination.UserTypeCode = (UserType)source.UserType;

            return destination;
        }
    }
}
