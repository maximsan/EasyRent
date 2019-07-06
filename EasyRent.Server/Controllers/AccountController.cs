using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EasyRent.Data;
using EasyRent.Data.Entities;
using EasyRent.Server.Common;
using EasyRent.Server.Common.Validators;
using EasyRent.Server.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyRent.Server.Controllers
{
    public class AccountController : BaseController
    {
        protected readonly SignInManager<User> SignInManager;

        public AccountController(SignInManager<User> signInManager, UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            SignInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel model)
        {
            SignInValidator modelValidator = GetService<SignInValidator>();

            if (!modelValidator.Validate(model).IsValid)
            {
                return Json(new JsonResponseTemplate(false, "Invalid email or password"));
            }

            User user = await SignInManager.UserManager.FindByEmailAsync(model.Email);

            return user is null
                ? Json(new JsonResponseTemplate(false, string.Empty))
                : Json(new JsonResponseTemplate(
                           await SignInManager.CheckPasswordSignInAsync(user, model.Password, false), string.Empty));
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpModel model)
        {
            SignUpValidator modelValidator = GetService<SignUpValidator>();
            ValidationResult validatorResponse = modelValidator.Validate(model);

            if (!validatorResponse.IsValid)
            {
                return Json(new JsonResponseTemplate(false, validatorResponse.Errors.Select(q => q.ErrorMessage)));
            }

            var newUser = Mapper.Map<User>(model);

            var creatingResult = await SignInManager.UserManager.CreateAsync(newUser);

            return creatingResult.Succeeded
                ? Json(new JsonResponseTemplate(true, string.Empty))
                : Json(new JsonResponseTemplate(false, creatingResult.Errors.Select(q => q.Description)));
        }
    }
}