using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolManagement.Core
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required]
        public User Tutor { get; set; }
        [Required]
        public CourseGroup Group { get; set; }
    }
}
