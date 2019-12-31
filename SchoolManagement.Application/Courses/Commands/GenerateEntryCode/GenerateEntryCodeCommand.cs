using AutoMapper;
using SchoolManagement.Application.Helpers;
using SchoolManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.GenerateEntryCode
{
    public class GenerateEntryCodeCommand : IGenerateEntryCodeCommand
    {
        private readonly ICourseData courseData;

        public GenerateEntryCodeCommand(ICourseData courseData)
        {
            this.courseData = courseData;
        }

        public string GenerateEntryCode(int id)
        {
            var course = courseData.GetById(id);
            Guard.EnsureCourseExists(course, id);

            var entryCode = course.GenerateEntryCode();
            courseData.Update(course);
            
            return entryCode;
        }
    }
}
