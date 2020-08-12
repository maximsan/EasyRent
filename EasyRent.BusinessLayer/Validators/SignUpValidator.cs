using EasyRent.BusinessLayer.Extensions;
using EasyRent.BusinessLayer.Models;
using EasyRent.Common.Constants;
using EasyRent.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.BusinessLayer.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpModel>
    {
        public SignUpValidator(UserManager<User> userManager)
        {
            RuleFor(q => q.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty()
                .EmailAddress()
                .WithMessage(ErrorMessages.InvalidEmailFormat)
                .UserNotMustExist(userManager);

            RuleFor(q => q.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty();

            RuleFor(q => q.UserName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty()
                .UserNotMustExist(userManager);

            RuleFor(q => q.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty();

            RuleFor(q => q.ConfirmPassword)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty()
                .Equal(q => q.Password)
                .WithMessage(ErrorMessages.ConfirmPasswordInvalid);

            RuleFor(q => q.ReturnUrl)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty();
        }
    }
}