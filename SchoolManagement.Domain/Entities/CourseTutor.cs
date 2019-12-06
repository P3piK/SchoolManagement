using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Domain.Entities
{
    public class CourseTutor
    {
        [ForeignKey("CourseFK")]
        public Course Course { get; set; }

        [ForeignKey("UserFK")]
        public User Tutor { get; set; }
    }
}
