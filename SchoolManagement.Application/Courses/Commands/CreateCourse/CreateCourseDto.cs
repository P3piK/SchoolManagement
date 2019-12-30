using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Commands.CreateCourse
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public int TutorId { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public DateTime? BeginDate { get; set; }
    }
}
