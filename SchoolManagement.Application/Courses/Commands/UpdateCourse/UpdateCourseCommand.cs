using AutoMapper;
using SchoolManagement.Application.Helpers;
using SchoolManagement.Application.Interfaces;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.UpdateCourse
{
    public class UpdateCourseCommand : IUpdateCourseCommand
    {
        private readonly ICourseData courseData;
        private readonly IUserData userData;
        private readonly IMapper mapper;

        public UpdateCourseCommand(ICourseData courseData, IUserData userData, IMapper mapper)
        {
            this.courseData = courseData;
            this.userData = userData;
            this.mapper = mapper;
        }

        public void UpdateCourse(int id, UpdateCourseDto courseDto)
        {
            var course = courseData.GetById(id);
            Guard.EnsureCourseExists(course, id);
            var tutor = userData.GetByTutorId(courseDto.TutorId);
            Guard.EnsureTutorExists(tutor, courseDto.TutorId);

            course = mapper.Map<Course>(courseDto);
            course.Tutor = tutor;

            courseData.Update(course);
        }
    }
}
