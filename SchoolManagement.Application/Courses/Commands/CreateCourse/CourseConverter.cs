using AutoMapper;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.CreateCourse
{
    public class CourseConverter : ITypeConverter<CreateCourseDto, Course>
    {
        public Course Convert(CreateCourseDto source, Course destination, ResolutionContext context)
        {
            if (destination == null)
            {
                destination = new Course();
            }

            destination.BeginDate = source.BeginDate;
            destination.Description = source.Description;
            destination.Name = source.Name;
            destination.Password = source.Password;

            return destination;
        }
    }
}
