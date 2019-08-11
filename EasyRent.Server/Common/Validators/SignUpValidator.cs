using EasyRent.Data.Entities;
using EasyRent.Server.Common.Extentions;
using EasyRent.Server.Models;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using EasyRent.Server.Common.Constants;

namespace EasyRent.Server.Common.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpModel>
    {
        public SignUpValidator(UserManager<User> userManager)
        {
            RuleFor(q => q.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(ErrorMessages.EmailRequired)
                .NotNull()
                .WithMessage(ErrorMessages.EmailRequired)
                .EmailAddress()
                .WithMessage(ErrorMessages.InvalidEmailFormat);

            RuleFor(q => q.Password).Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ErrorMessages.PasswordRequired)
                .NotEmpty()
                .WithMessage(ErrorMessages.PasswordRequired);

            RuleFor(q => q.UserName).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .WithMessage(ErrorMessages.UserNameRequired)
                .NotNull()
                .WithMessage(ErrorMessages.UserNameRequired)
                .UserNotMustExist(userManager);

            RuleFor(q => q.Password).Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ErrorMessages.PasswordRequired)
                .NotEmpty()
                .WithMessage(ErrorMessages.PasswordRequired);

            RuleFor(q => q.ConfirmPassword).Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull()
                .Equal(q => q.Password);
        }
    }
}