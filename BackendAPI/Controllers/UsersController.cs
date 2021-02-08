using BackendAPI.Services.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [Route("users")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_usersService.GetUsers());
        }

        [Route("users/{id}")]
        [HttpGet]
        public IActionResult GetUser(int id)
        {
            return Ok(_usersService.GetUser(id));
        }

        [Route("users/{id}/{first_name}/{last_name}/{email}/{telephone}")]
        [HttpPost]
        public IActionResult UpdateUser(int id, string first_name, string last_name, string email, string telephone)
        {
            return Ok(_usersService.UpdateUser(id, first_name, last_name, email, telephone));
        }
    }
}
