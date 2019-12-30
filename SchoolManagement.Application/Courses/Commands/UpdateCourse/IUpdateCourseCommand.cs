using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.UpdateCourse
{
    public interface IUpdateCourseCommand
    {
        void UpdateCourse(int id, UpdateCourseDto courseDto);
    }
}
