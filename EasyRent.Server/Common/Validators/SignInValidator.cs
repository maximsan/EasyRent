﻿using EasyRent.Data.Entities;
using EasyRent.Server.Common.Constants;
using EasyRent.Server.Common.Extentions;
using EasyRent.Server.Models;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.Server.Common.Validators
{
    public class SignInValidator : AbstractValidator<SignInModel>
    {
        public SignInValidator(SignInManager<User> signInManager)
        {
            RuleFor(q => q.Email).Cascade(CascadeMode.StopOnFirstFailure)
                .EmailAddress()
                .WithMessage(ErrorMessages.InvalidEmailFormat)
                .NotEmpty()
                .WithMessage(ErrorMessages.EmailRequired)
                .NotNull()
                .WithMessage(ErrorMessages.EmailRequired)
                .UserMustExist(signInManager.UserManager);

            RuleFor(q => q.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotNull()
                .WithMessage(ErrorMessages.PasswordRequired)
                .NotEmpty()
                .WithMessage(ErrorMessages.PasswordRequired)
                .Must((model, password) => password.ValidatePassword(model.Email, signInManager.UserManager))
                .WithMessage(ErrorMessages.InvalidPassword);
        }
    }
}
