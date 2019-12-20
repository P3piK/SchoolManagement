using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Domain.Entities
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        [ForeignKey("TutorFK")]
        public User Tutor { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string EntryCode { get; set; }
        public string EntryCodeDate { get; set; }
        public DateTime? BeginDate { get; set; }

    }
}
