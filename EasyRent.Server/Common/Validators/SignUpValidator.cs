using EasyRent.Server.Models;
using FluentValidation;

namespace EasyRent.Server.Common.Validators
{
    public class SignUpValidator : AbstractValidator<SignUpModel>
    {
        public SignUpValidator()
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
                .WithMessage("Login cannot be empty.");

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
