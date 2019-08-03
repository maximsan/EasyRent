using EasyRent.Data.Entities;
using EasyRent.Server.Common.Extentions;
using EasyRent.Server.Models;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.Server.Common.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpModel>
    {
        public SignUpValidator(UserManager<User> userManager)
        {
            RuleFor(q => q.Email)
                .EmailAddress()
                .WithMessage("Invalid email")
                .NotEmpty()
                .WithMessage("Email cannot be empty.")
                .NotNull()
                .WithMessage("Email cannot be empty.");

            RuleFor(q => q.Password)
                .NotNull()
                .WithMessage("Password cannot be empty.")
                .NotEmpty()
                .WithMessage("Password cannot be empty.");

            RuleFor(q => q.UserName)
                .NotEmpty()
                .WithMessage("Login cannot be empty.")
                .NotNull()
                .WithMessage("Login cannot be empty.")
                .UserExists(userManager);

            RuleFor(q => q.Password)
                .NotNull()
                .WithMessage("Password cannot be empty.")
                .NotEmpty()
                .WithMessage("Password cannot be empty.");

            RuleFor(q => q.ConfirmPassword)
                .NotEmpty()
                .NotNull()
                .Equal(q => q.Password);
        }
    }
}