using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Core
{
    public class Lesson : EntityRecordBase
    {
        public int Id { get; set; }
        [Required, ForeignKey("CourseFK")]
        public Course Course { get; set; }
        [StringLength(200)]
        public string Subject { get; set; }
        [Timestamp]
        public DateTime StartDate { get; set; }
        [Timestamp]
        public DateTime EndDate { get; set; }

    }
}
