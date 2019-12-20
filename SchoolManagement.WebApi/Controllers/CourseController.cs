using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Courses.Queries.GetCourse;

namespace SchoolManagement.WebApi.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IGetCourseQuery getCourseQuery;

        public CourseController(IGetCourseQuery getCourseQuery)
        {
            this.getCourseQuery = getCourseQuery;
        }

        // GET: api/Courses
        [HttpGet]
        public ActionResult Get()
        {
            var courses = getCourseQuery.FindAll();
            return Ok(courses);
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = getCourseQuery.GetById(id);
            return Ok(course);
        }

        // GET: api/Courses/name
        [HttpGet("{name}")]
        public ActionResult Get(string name)
        {
            var courses = getCourseQuery.FindByName(name);
            return Ok(courses);
        }

        // GET: api/Course?tutorId=5
        [HttpGet]
        public ActionResult GetByTutor([FromQuery] int tutorId)
        {
            var courses = getCourseQuery.FindByTutor(tutorId);
            return Ok(courses);
        }

        // POST: api/Course
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        // PUT: api/Course/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            return Ok();
        }
    }
}
