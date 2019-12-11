using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Domain.Entities
{
    public class CourseGrade : EntityBase
    {
        [ForeignKey("CourseFK")]
        public Course Course { get; set; }
        [ForeignKey("UserFK")]
        public User User { get; set; }
        public double Grade { get; set; }
    }
}
