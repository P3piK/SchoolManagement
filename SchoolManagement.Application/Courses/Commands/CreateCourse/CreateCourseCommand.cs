using AutoMapper;
using SchoolManagement.Application.Helpers;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.CreateCourse
{
    public class CreateCourseCommand : ICreateCourseCommand
    {
        private readonly ICourseData courseData;
        private readonly IUserData userData;
        private readonly IMapper mapper;

        public CreateCourseCommand(ICourseData courseData, IUserData userData, IMapper mapper)
        {
            this.courseData = courseData;
            this.userData = userData;
            this.mapper = mapper;
        }

        public void CreateCourse(CreateCourseDto courseDto)
        {
            var tutor = userData.GetByTutorId(courseDto.TutorId);
            Guard.EnsureTutorExists(tutor, courseDto.TutorId);

            var course = mapper.Map<Course>(courseDto);
            course.Tutor = tutor;

            courseData.Insert(course);
        }
    }
}
