using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyRent.Server.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Route("[controller]")]
    //[ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost("sign-in")]
        public void SignIn ([FromBody]SignInUserModel user)
        {
            var newUser = user;
        }

        [HttpPost("sign-up")]
        public void SignUp([FromBody]SignUpUserModel user)
        {
            var newUser = user;
        }
    }
}