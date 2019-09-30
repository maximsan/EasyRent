using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRent.Common;
using EasyRent.Common.Constants;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Data;
using EasyRent.Data.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using System.Collections.Generic;
using System.Security.Claims;
using IdentityServer4.Events;
using IdentityServer4.Extensions;
using IdentityServer4.Models;
using IdentityServer4.Services;
using IdentityServer4.Stores;

namespace EasyRent.Server.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class AccountController : BaseController
    {
        private readonly IIdentityServerInteractionService Interaction;
        private readonly IClientStore ClientStore;
        private readonly IAuthenticationSchemeProvider SchemeProvider;
        private readonly IEventService Events;
        protected readonly SignInManager<User> SignInManager;

        public AccountController(SignInManager<User> signInManager,
            IMapper mapper, IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events) : base(mapper)
        {
            Interaction = interaction;
            ClientStore = clientStore;
            SchemeProvider = schemeProvider;
            Events = events;
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
                return Json(new JsonResponseTemplate(false, ModelStateErrors));
            }

            User user = SignInManager.UserManager.FindByUserNameOrEmail(resetPassword.Email);

            IdentityResult result =
                await SignInManager.UserManager.ResetPasswordAsync(user, resetPassword.Key, resetPassword.Password);

            return Json(new JsonResponseTemplate(result.Succeeded, result.Errors.Select(q => q.Description)));
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] SignInModel model, [FromQuery] string ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.SignInError));
            }

            AuthorizationRequest context = await Interaction.GetAuthorizationContextAsync(ReturnUrl);

            var user = await SignInManager.UserManager.FindByEmailAsync(model.Email);

            SignInResult trySignIn = await SignInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (trySignIn.Succeeded)
            {
                await Events.RaiseAsync(new UserLoginSuccessEvent(user.UserName, user.Id, user.UserName));

                if (context != null)
                {
                    return Redirect(ReturnUrl);
                }

                if (Url.IsLocalUrl(ReturnUrl))
                {
                    return Redirect(ReturnUrl);
                }
            }

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
                return Json(new JsonResponseTemplate(false, ModelStateErrors));
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
                return Json(new JsonResponseTemplate(false, ModelStateErrors));
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
