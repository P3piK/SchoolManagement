using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolManagement.Domain.Entities
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        [ForeignKey("UserFK")]
        public User Tutor { get; set; }
        public string Code { get; set; }
        public string CodeGenerationDate { get; set; }

    }
}
