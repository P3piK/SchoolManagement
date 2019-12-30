using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Exceptions
{
    public class CourseNotExistsException : Exception
    {
        public CourseNotExistsException(int id)
            : base(String.Format("Course with id: {0} doesn't exist.", id))
        {
        }
    }
}
