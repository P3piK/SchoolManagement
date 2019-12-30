using SchoolManagement.Application.Users.Queries.GetUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Queries.GetCourse
{
    public class GetCourseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tutor { get; set; }
        public string Descritpion { get; set; }
        public DateTime? BeginDate { get; set; }
    }
}
