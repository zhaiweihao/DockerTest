using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreTest.Service;

namespace CoreTest.Controllers
{
    [Route("api/v1/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async  Task<IActionResult> FindUser(int id)
        {
            var result = await _userService.Find(id);
            return Ok(result);
        }
    }
}