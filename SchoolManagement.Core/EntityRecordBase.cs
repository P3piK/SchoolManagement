using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Core
{
    public abstract class EntityRecordBase
    {
        public DateTime EditDate { get; set; }


        public void SetupSystemFields()
        {
            EditDate = DateTime.Now;
        }
    }
}