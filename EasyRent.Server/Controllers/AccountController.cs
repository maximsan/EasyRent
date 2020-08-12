using EasyRent.BusinessLayer.Interfaces;
using EasyRent.BusinessLayer.Models;
using EasyRent.Server.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace EasyRent.IdentityServer.Controllers
{
    [Route("account")]
    public class AccountController : BaseController
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("reset-password-token")]
        public async Task<IActionResult> GetResetPasswordTokenAsync([FromQuery, FromBody] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return BadRequest();
            }

            var resetTokenResult = await _userService.GetResetPaswordTokenAsync(email);

            return Ok(resetTokenResult);
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPasswordAsync([FromBody] ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var resetPasswordResult = await _userService.ResetPasswordAsync(model);

            if (!resetPasswordResult.Succeeded)
            {
                foreach (var item in resetPasswordResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                return ValidationProblem(ModelState);
            }

            return Ok();
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignInAsync([FromBody] SignInModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            SignInResult signInStatus = await _userService.SignInAsync(model);

            return signInStatus.Succeeded
                ? Ok()
                : (IActionResult)BadRequest();
        }

        [HttpGet("sign-out")]
        public async Task<IActionResult> SignOutAsync()
        {
            await _userService.SignOutAsync();

            return Ok();
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUpAsync([FromBody] SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var creatingResult = await _userService.SignUpAsync(model);

            if (!creatingResult.Succeeded)
            {
                foreach (var item in creatingResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                return ValidationProblem(ModelState);
            }

            return Ok();
        }
    }
}