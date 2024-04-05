using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JwtTokenApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtTokenApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public string GetData() {
            return "Authenticated with JWT";
        }

        [HttpGet]
        [Route("Details")]
        public string Details() {
            return "Authenticated with JWT";
        }

        [Authorize]
        [HttpPost]
        public string AddUser(User user) {
            return "User added with username " + user.UserName;
        }
    }
}