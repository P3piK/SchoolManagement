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
        public DateTime? EntryCodeDate { get; set; }
        public DateTime? BeginDate { get; set; }


        public string GenerateEntryCode()
        {
            this.EntryCode = Guid.NewGuid().ToString().Substring(0, 6);
            this.EntryCodeDate = DateTime.Now;

            return this.EntryCode;
        }

    }
}
