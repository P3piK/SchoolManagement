using AutoMapper;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Queries.GetCourse
{
    public class GetCourseConverter : ITypeConverter<Course, GetCourseDto>
    {
        public GetCourseDto Convert(Course source, GetCourseDto destination, ResolutionContext context)
        {
            if (destination == null)
            {
                destination = new GetCourseDto();
            }

            destination.BeginDate = source.BeginDate;
            destination.Descritpion = source.Description;
            destination.Id = source.Id;
            destination.Name = source.Name;
            destination.Tutor = source.Tutor.Name;

            return destination;
        }
    }
}
