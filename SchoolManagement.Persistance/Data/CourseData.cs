using SchoolManagement.Application.Interfaces;
using SchoolManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolManagement.Persistance.Data
{
    public class CourseData : SqlBaseData<Course>, ICourseData
    {
        public CourseData(SmContext context)
            : base(context)
        {
        }

        public IEnumerable<Course> FindAll()
        {
            return Context.Courses;
        }

        public IEnumerable<Course> FindByPartialName(string name)
        {
            return Context.Courses.Where(c => c.Name.Contains(name));
        }

        public IEnumerable<Course> FindByTutor(int tutorId)
        {
            return Context.Courses.Where(c => c.Tutor.Id == tutorId);
        }

        public Course GetById(int id)
        {
            return Context.Courses.Where(c => c.Id == id).SingleOrDefault();
        }
    }
}
