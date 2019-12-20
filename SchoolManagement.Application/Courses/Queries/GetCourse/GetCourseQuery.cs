using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Queries.GetCourse
{
    public class GetCourseQuery : IGetCourseQuery
    {
        public IEnumerable<GetCourseDto> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetCourseDto> FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GetCourseDto> FindByTutor(int tutorId)
        {
            throw new NotImplementedException();
        }

        public GetCourseDto GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
