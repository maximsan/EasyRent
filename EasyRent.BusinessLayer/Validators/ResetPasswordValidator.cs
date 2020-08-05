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
                .NotEmpty()
                .WithMessage(ErrorMessages.EmailRequired)
                .NotNull()
                .WithMessage(ErrorMessages.EmailRequired)
                .EmailAddress()
                .WithMessage(ErrorMessages.InvalidEmailFormat)
                .UserMustExist(signInManager.UserManager);

            RuleFor(q => q.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ErrorMessages.PasswordRequired)
                .NotEmpty()
                .WithMessage(ErrorMessages.PasswordRequired);
        }
    }
}