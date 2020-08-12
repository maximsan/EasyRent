﻿using EasyRent.BusinessLayer.Extensions;
using EasyRent.BusinessLayer.Models;
using EasyRent.Common.Constants;
using EasyRent.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.BusinessLayer.Validators
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordModel>
    {
        public ResetPasswordValidator(SignInManager<User> signInManager)
        {
            RuleFor(q => q.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty()
                .EmailAddress()
                .WithMessage(ErrorMessages.InvalidEmailFormat)
                .UserMustExist(signInManager.UserManager);

            RuleFor(q => q.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNullOrEmpty();

            RuleFor(q => q.ConfirmPassword)
                .Equal(q => q.Password)
                .WithMessage(ErrorMessages.ConfirmPasswordInvalid);
        }
    }
}