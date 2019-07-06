using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRent.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("sign-in")]
        public void SignIn (SignInUserModel user)
        {
            var newUser = user;
        }
    }
}