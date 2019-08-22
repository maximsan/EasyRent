using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Server.Common;
using EasyRent.Server.Common.Constants;
using EasyRent.Server.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class AccountController : BaseController
    {
        protected readonly SignInManager<User> SignInManager;

        public AccountController(SignInManager<User> signInManager, UnitOfWork unitOfWork, IMapper mapper) : base(
            unitOfWork, mapper)
        {
            SignInManager = signInManager;
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            ValidationResult validationResult = GetService<IValidator<SignInModel>>()
                .Validate(model);

            if (!validationResult.IsValid)
            {
                return Json(new JsonResponseTemplate(false, ErrorMessages.SignInError));
            }

            User user = await SignInManager.UserManager.FindByEmailAsync(model.Email);

            if (await SignInManager.CanSignInAsync(user))
            {
                await SignInManager.SignInAsync(user, false);

                return Json(new JsonResponseTemplate(true, string.Empty));
            }

            return Json(new JsonResponseTemplate(false, ErrorMessages.SignInError));
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
            ValidationResult validatorResponse = GetService<IValidator<SignUpModel>>()
                .Validate(model);

            if (!validatorResponse.IsValid)
            {
                return Json(new JsonResponseTemplate(false, validatorResponse.Errors.Select(q => q.ErrorMessage)));
            }

            User newUser = Mapper.Map<User>(model);

            IdentityResult creatingResult = await SignInManager.UserManager.CreateAsync(newUser);

            if (creatingResult.Succeeded)
            {
                await SignInManager.UserManager.AddPasswordAsync(newUser, model.Password);
            }

            return creatingResult.Succeeded
                ? Json(new JsonResponseTemplate(true, string.Empty))
                : Json(new JsonResponseTemplate(false, creatingResult.Errors.Select(q => q.Description)));
        }
    }
}