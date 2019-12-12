using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Application.Users.Commands.CreateUser;
using SchoolManagement.Application.Users.Commands.UpdateUser;
using SchoolManagement.Application.Users.Exceptions;
using SchoolManagement.Application.Users.Queries.GetUser;

namespace SchoolManagement.WebApi.Controllers
{
    //[Authorize]
    [RequireHttps]
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IGetUserQuery getUserQuery;
        private readonly ICreateUserCommand createUserCommand;

        public UsersController(IGetUserQuery getUserQuery, 
            ICreateUserCommand createUserCommand)
        {
            this.getUserQuery = getUserQuery;
            this.createUserCommand = createUserCommand;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            return Ok(getUserQuery.GetAllUsers());
        }

        [HttpGet]
        [Route("{login}")]
        public IActionResult GetUserByLogin(string login)
        {
            return Ok(getUserQuery.GetByLogin(login));
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserDto dto)
        {
            try
            {
                createUserCommand.CreateUser(dto);
                return Ok();
            }
            catch (AccountExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateUser(UpdateUserDto dto)
        {
            try
            {
                // update
                return Ok();
            }
            catch (AccountNotExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}