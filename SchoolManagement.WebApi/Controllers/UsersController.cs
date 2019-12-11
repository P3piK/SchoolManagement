using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Users.Dto;
using SchoolManagement.Application.Users.Interfaces;

namespace SchoolManagement.WebApi.Controllers
{
    //[Authorize]
    [RequireHttps]
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IGetUserQuery getUserQuery;

        public UsersController(IGetUserQuery getUserQuery)
        {
            this.getUserQuery = getUserQuery;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return new JsonResult(getUserQuery.GetAllUsers());
        }
    }
}