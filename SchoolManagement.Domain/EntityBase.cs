using System;

namespace SchoolManagement.Domain
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime EditDate { get; set; }


        public void SetupSystemFields()
        {
            EditDate = DateTime.Now;
        }
    }
}