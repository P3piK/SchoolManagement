using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Interfaces
{
    public interface ICourseData : ISqlBaseData<Course>
    {
        Course GetById(int id);
        IEnumerable<Course> FindByPartialName(string name);
        IEnumerable<Course> FindByTutor(int tutorId);
        IEnumerable<Course> FindAll();
    }
}
