using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Queries.GetCourse
{
    public interface IGetCourseQuery
    {
        GetCourseDto GetById(int id);
        IEnumerable<GetCourseDto> FindByName(string name);
        IEnumerable<GetCourseDto> FindAll();
        IEnumerable<GetCourseDto> FindByTutor(int tutorId);
    }
}
