using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRent.Common.Constants;
using EasyRent.Common.Extentions;
using EasyRent.Common.Models;
using EasyRent.Data.Entities;
using IdentityServer4.Events;
using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;
using EasyRent.Common.Attributes;
using IdentityServer4.Extensions;
using Microsoft.AspNetCore.Cors;

namespace EasyRent.IdentityServer.Controllers
{
    [SecurityHeaders]
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
            IMapper mapper,
            IIdentityServerInteractionService interaction,
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

        [HttpGet("[action]")]
        public IActionResult SignIn(string returnUrl)
        {
            var vm = new SignInModel { ReturnUrl = returnUrl };

            return View(vm);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await SignInManager.UserManager.FindByEmailAsync(model.Email);

            SignInResult trySignIn = await SignInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (trySignIn.Succeeded)
            {
                await Events.RaiseAsync(new UserLoginSuccessEvent(user.UserName, user.Id, user.UserName));

                return Redirect(model.ReturnUrl);
            }

            await Events.RaiseAsync(new UserLoginFailureEvent(user.UserName, "User cannot sign in."));

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

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp([FromBody] SignUpModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new JsonResponseTemplate(false, ModelStateErrors));
            }

            User newUser = Mapper.Map<User>(model);

            var creatingResult = await SignInManager.UserManager.CreateAsync(newUser, model.Password);

            if (creatingResult.Succeeded)
            {
                return Ok(creatingResult.Succeeded);
            }

            return Json(new JsonResponseTemplate(creatingResult.Succeeded, creatingResult.Errors.Select(q => q.Description)));
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
