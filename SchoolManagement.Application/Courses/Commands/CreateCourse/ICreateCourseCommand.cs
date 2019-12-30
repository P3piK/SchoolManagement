using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.CreateCourse
{
    public interface ICreateCourseCommand
    {
        void CreateCourse(CreateCourseDto course);
    }
}
