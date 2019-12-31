using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Courses.Commands.CreateCourse;
using SchoolManagement.Application.Courses.Commands.GenerateEntryCode;
using SchoolManagement.Application.Courses.Commands.UpdateCourse;
using SchoolManagement.Application.Courses.Exceptions;
using SchoolManagement.Application.Courses.Queries.GetCourse;
using SchoolManagement.Application.Users.Exceptions;

namespace SchoolManagement.WebApi.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        #region Fields

        private readonly IGetCourseQuery getCourse;
        private readonly ICreateCourseCommand createCourse;
        private readonly IUpdateCourseCommand updateCourse;
        private readonly IGenerateEntryCodeCommand accessCourse;

        #endregion

        #region Constructor 

        public CourseController(IGetCourseQuery getCourseQuery, 
            ICreateCourseCommand createCourseCommand, 
            IUpdateCourseCommand updateCourse,
            IGenerateEntryCodeCommand accessCourse)
        {
            this.getCourse = getCourseQuery;
            this.createCourse = createCourseCommand;
            this.updateCourse = updateCourse;
            this.accessCourse = accessCourse;
        }

        #endregion

        // GET: api/Courses
        [HttpGet]
        public ActionResult Get()
        {
            var courses = getCourse.FindAll();
            return Ok(courses);
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var course = getCourse.GetById(id);
            return Ok(course);
        }

        // GET: api/Courses/SomeName
        [HttpGet("{name}")]
        public ActionResult Get(string name)
        {
            var courses = getCourse.FindByName(name);
            return Ok(courses);
        }

        // GET: api/Courses?tutorId=5
        [HttpGet]
        public ActionResult GetByTutor([FromQuery] int tutorId)
        {
            var courses = getCourse.FindByTutor(tutorId);
            return Ok(courses);
        }

        // POST: api/Courses
        [HttpPost]
        public ActionResult Post([FromBody] CreateCourseDto courseDto)
        {
            try
            {
                createCourse.CreateCourse(courseDto);
                return Ok();
            }
            catch (TutorNotExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Courses/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] UpdateCourseDto courseDto)
        {
            try
            {
                updateCourse.UpdateCourse(id, courseDto);
                return Ok();
            }
            catch (CourseNotExistsException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (TutorNotExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/Courses/5/code
        [HttpGet("{id}/code")]
        public ActionResult GenerateEntryCode(int id)
        {
            try
            {
                accessCourse.GenerateEntryCode(id);
                return Ok();
            }
            catch (CourseNotExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
