using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Core
{
    public class CourseGroup : EntityRecordBase
    {
        public int Id { get; set; }
        [ForeignKey("UserFK")]
        public User User { get; set; }
        [ForeignKey("CourseFK")]
        public Course Course { get; set; }

    }
}
