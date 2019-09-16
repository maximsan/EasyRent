using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Common;
using EasyRent.Common.Constants;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCaching.Internal;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace EasyRent.Server.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class AccountController : BaseController
    {
        protected readonly SignInManager<User> SignInManager;

        public AccountController(SignInManager<User> signInManager, IMapper mapper) : base(mapper)
        {
            SignInManager = signInManager;
        }

        [HttpPost("reset-password-token")]
        public async Task<IActionResult> ResetPasswordToken([FromBody] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.EmailRequired));
            }

            User user = SignInManager.UserManager.FindByUserNameOrEmail(email);

            if (user is null)
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.UserNotExist));
            }

            return Json(new JsonResponseTemplate(await SignInManager.UserManager.GeneratePasswordResetTokenAsync(user), string.Empty));
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel resetPassword)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, GetModelStateErrors()));
            }

            User user = SignInManager.UserManager.FindByUserNameOrEmail(resetPassword.Email);

            IdentityResult result =
                await SignInManager.UserManager.ResetPasswordAsync(user, resetPassword.Key, resetPassword.Password);

            return Json(new JsonResponseTemplate(result.Succeeded, result.Errors.Select(q => q.Description)));
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] SignInModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.SignInError));
            }

            var user = await SignInManager.UserManager.FindByEmailAsync(model.Email);

            SignInResult trySignIn = await SignInManager.PasswordSignInAsync(user, model.Password, false, false);

            return Json(new JsonResponseTemplate(trySignIn.Succeeded,
                                                 trySignIn.Succeeded ? string.Empty : ErrorMessages.SignInError));
        }

        [Route("sign-out")]
        public async Task<IActionResult> SignOut(int? id)
        {
            if (!id.HasValue)
            {
                return Json(new JsonResponseTemplate(false, "Bad request. Try again."));
            }

            await SignInManager.SignOutAsync();

            return Json(new JsonResponseTemplate(true, string.Empty));
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, GetModelStateErrors()));
            }

            User newUser = Mapper.Map<User>(model);

            IdentityResult creatingResult = await SignInManager.UserManager.CreateAsync(newUser, model.Password);

            return Json(new JsonResponseTemplate(creatingResult.Succeeded,
                                                 creatingResult.Succeeded
                                                     ? Enumerable.Empty<string>()
                                                     : creatingResult.Errors.Select(q => q.Description)));
        }

        [HttpPost("check-password")]
        public async Task<IActionResult> CheckPassword([FromBody] ResetPasswordModel checkPassword)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, GetModelStateErrors()));
            }

            var user = await SignInManager.UserManager.FindByEmailAsync(checkPassword.Email);

            if (user is null)
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.UserNotExist));
            }

            var result = await SignInManager.UserManager.CheckPasswordAsync(user, checkPassword.Password);

            return Json(new JsonResponseTemplate(result, string.Empty));
        }
    }
}