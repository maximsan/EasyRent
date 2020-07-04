using EasyRent.Data.Entities;
using EasyRent.Common.Extensions;
using EasyRent.Common.Models;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using EasyRent.Common.Constants;

namespace EasyRent.Common.Validators
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
                .WithMessage(ErrorMessages.InvalidEmailFormat)
                .UserNotMustExist(userManager);

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

            RuleFor(q => q.ConfirmPassword)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull()
                .Equal(q => q.Password)
                .WithMessage(ErrorMessages.ConfirmPasswordInvalid);

            RuleFor(q => q.ReturnUrl)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty()
                .NotNull();
        }
    }
}