using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Core
{
    public class CourseTutor
    {
        public int Id { get; set; }

        [ForeignKey("CourseFK")]
        public Course Course { get; set; }

        [ForeignKey("UserFK")]
        public User Tutor { get; set; }
    }
}
