using EasyRent.Common.Attributes;
using EasyRent.Common.Constants;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Common.Services;
using EasyRent.Data.Entities;
using EasyRent.Server.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace EasyRent.IdentityServer.Controllers
{
    [SecurityHeaders]
    [ResponseCache(NoStore = true, Duration = 0)]
    public class AccountController : BaseController
    {
        protected readonly SignInManager<User> signInManager;
        private readonly IUserService userService;

        public AccountController(SignInManager<User> signInManager,
            IUserService userService)
        {
            this.signInManager = signInManager;
            this.userService = userService;
        }

        //TODO: Implement by user service
        [HttpPost]
        public async Task<IActionResult> ResetPasswordToken([FromBody] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.EmailRequired));
            }

            User user = await signInManager.UserManager.FindByUserNameOrEmailAsync(email);

            return user is null
                ? Json(new JsonResponseTemplate(false, ErrorMessages.UserNotExist))
                : Json(new JsonResponseTemplate(await signInManager.UserManager.GeneratePasswordResetTokenAsync(user), string.Empty));
        }

        //TODO: Implement by user service
        [HttpPost]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel resetPassword)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            User user = await signInManager.UserManager.FindByUserNameOrEmailAsync(resetPassword.Email);

            IdentityResult result = await signInManager.UserManager.ResetPasswordAsync(user, resetPassword.Key, resetPassword.Password).ConfigureAwait(false);

            return Json(new JsonResponseTemplate(result.Succeeded, result.Errors.Select(q => q.Description)));
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] SignInModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            SignInResult signInStatus = await userService.SignInAsync(model);

            return signInStatus.Succeeded 
                ? Ok() 
                : (IActionResult)BadRequest();
        }

        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await userService.SignOutAsync();

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            var creatingResult = await userService.SignUpAsync(model);

            return creatingResult.Succeeded
                ? Ok()
                : (IActionResult)BadRequest();
        }

        //TODO: Implement by user service
        [HttpPost]
        public async Task<IActionResult> CheckPassword([FromBody] ResetPasswordModel checkPassword)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            var user = await signInManager.UserManager.FindByEmailAsync(checkPassword.Email);

            if (user is null)
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.UserNotExist));
            }

            var result = await signInManager.UserManager.CheckPasswordAsync(user, checkPassword.Password);

            return Json(new JsonResponseTemplate(result, string.Empty));
        }
    }
}