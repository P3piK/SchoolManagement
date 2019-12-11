using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Domain.Entities
{
    public class CourseGrade : EntityBase
    {
        public Course Course { get; set; }
        public User User { get; set; }
        public double Grade { get; set; }
    }
}
