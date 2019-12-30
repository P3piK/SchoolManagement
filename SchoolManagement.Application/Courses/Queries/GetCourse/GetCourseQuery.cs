using AutoMapper;
using SchoolManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolManagement.Application.Courses.Queries.GetCourse
{
    public class GetCourseQuery : IGetCourseQuery
    {
        private readonly ICourseData courseData;
        private readonly IMapper mapper;

        public GetCourseQuery(ICourseData courseData, IMapper mapper)
        {
            this.courseData = courseData;
            this.mapper = mapper;
        }

        public IEnumerable<GetCourseDto> FindAll()
        {
            var data = courseData.FindAll();
            return mapper.Map<IEnumerable<GetCourseDto>>(data);
        }

        public IEnumerable<GetCourseDto> FindByName(string name)
        {
            var data = courseData.FindByPartialName(name);
            return mapper.Map<IEnumerable<GetCourseDto>>(name);
        }

        public IEnumerable<GetCourseDto> FindByTutor(int tutorId)
        {
            var data = courseData.FindByTutor(tutorId);
            return mapper.Map<IEnumerable<GetCourseDto>>(data);
        }

        public GetCourseDto GetById(int id)
        {
            var course = courseData.GetById(id);
            return mapper.Map<GetCourseDto>(course);
        }
    }
}
