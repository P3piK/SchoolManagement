using AutoMapper;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Users.Commands.UpdateUser
{
    public class UpdateUserConverter : ITypeConverter<UpdateUserDto, User>
    {
        public User Convert(UpdateUserDto source, User destination, ResolutionContext context)
        {
            if (destination == null)
            {
                destination = new User();
            }

            destination.Address = source.Address;
            destination.BirthDate = source.BirthDate;
            destination.Login = source.Login;
            destination.Name = source.Name;
            destination.Phone = source.Phone;
            destination.StatusCode = (UserStatus)source.Status;
            destination.UserTypeCode = (UserType)source.UserType;

            if (!String.IsNullOrEmpty(source.NewLogin))
            {
                destination.Login = source.NewLogin;
            }

            return destination;
        }
    }
}
