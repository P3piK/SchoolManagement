using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Domain.Entities
{
    public class CourseGroup : EntityBase
    {
        [ForeignKey("UserFK")]
        public User User { get; set; }
        [ForeignKey("CourseFK")]
        public Course Course { get; set; }

    }
}
