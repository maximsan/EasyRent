using AutoMapper;
using EasyRent.Common.Attributes;
using EasyRent.Common.Constants;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Common.Services;
using EasyRent.Data.Entities;
using IdentityServer4.Events;
using IdentityServer4.Extensions;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
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
        private readonly IIdentityServerInteractionService Interaction;
        private readonly IClientStore ClientStore;
        private readonly IAuthenticationSchemeProvider SchemeProvider;
        private readonly IEventService Events;
        protected readonly SignInManager<User> SignInManager;
        private readonly IUserService userService;

        public AccountController(SignInManager<User> signInManager,
            IMapper mapper,
            IIdentityServerInteractionService interaction,
            IClientStore clientStore,
            IAuthenticationSchemeProvider schemeProvider,
            IEventService events,
            IUserService userService) : base(mapper)
        {
            Interaction = interaction;
            ClientStore = clientStore;
            SchemeProvider = schemeProvider;
            Events = events;
            SignInManager = signInManager;
            this.userService = userService;
        }

        [HttpPost("reset-password-token")]
        public async Task<IActionResult> ResetPasswordToken([FromBody] string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.EmailRequired));
            }

            User user = await SignInManager.UserManager.FindByUserNameOrEmailAsync(email);

            return user is null
                ? Json(new JsonResponseTemplate(false, ErrorMessages.UserNotExist))
                : Json(new JsonResponseTemplate(await SignInManager.UserManager.GeneratePasswordResetTokenAsync(user), string.Empty));
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel resetPassword)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
            }

            User user = await SignInManager.UserManager.FindByUserNameOrEmailAsync(resetPassword.Email);

            IdentityResult result = await SignInManager.UserManager.ResetPasswordAsync(user, resetPassword.Key, resetPassword.Password).ConfigureAwait(false);

            return Json(new JsonResponseTemplate(result.Succeeded, result.Errors.Select(q => q.Description)));
        }

        [HttpGet]
        public IActionResult SignIn(string returnUrl)
        {
            if(returnUrl.IsNullOrWhiteSpace())
            {
                return BadRequest();
            }

            var model = new SignInModel { ReturnUrl = returnUrl };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromForm] SignInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            SignInResult signInStatus = await userService.SignInAsync(model);

            if (signInStatus.Succeeded)
            {
                var user = await userService.FindAsync(model.Email);
                await Events.RaiseAsync(new UserLoginSuccessEvent(user.Email, user.Id, user.Email));

                return Redirect(model.ReturnUrl);
            }

            await Events.RaiseAsync(new UserLoginFailureEvent(model.Email, "User cannot sign in."));

            return View(model);
        }

        [HttpGet("sign-out")]
        public async Task<IActionResult> SignOut([FromQuery] string logoutId)
        {
            var context = await Interaction.GetLogoutContextAsync(logoutId.IsNotNullOrWhiteSpace()
                ? logoutId
                : await Interaction.CreateLogoutContextAsync());

            if (context is null)
            {
                return Json(false);
            }

            await SignInManager.SignOutAsync();

            await Events.RaiseAsync(new UserLogoutSuccessEvent(User.GetSubjectId(), User.GetDisplayName()));

            return Redirect(context.PostLogoutRedirectUri);
        }

        [HttpGet]
        public IActionResult SignUp(string returnUrl)
        {
            if (returnUrl.IsNullOrWhiteSpace())
            {
                return BadRequest();
            }

            var model = new SignUpModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignUp([FromForm] SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var creatingResult = await userService.SignUpAsync(model);

            return creatingResult.Succeeded
                ? await SignIn(new SignInModel { Email = model.Email, Password = model.Password, ReturnUrl = model.ReturnUrl })
                : View(model);
        }

        [HttpPost("check-password")]
        public async Task<IActionResult> CheckPassword([FromBody] ResetPasswordModel checkPassword)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem();
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