using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagement.Core
{
    public class CourseGroup
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public User User { get; set; }
        [Key]
        public Course Course { get; set; }
    }
}
