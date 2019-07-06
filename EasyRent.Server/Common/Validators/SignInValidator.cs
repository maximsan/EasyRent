using EasyRent.Server.Models;
using FluentValidation;

namespace EasyRent.Server.Common.Validators
{
    public class SignInValidator : AbstractValidator<SignInModel>
    {
        public SignInValidator()
        {
            RuleFor(q => q.Email)
                .EmailAddress()
                .NotEmpty()
                .NotNull();

            RuleFor(q => q.Password)
                .NotNull()
                .NotEmpty();
        }
    }
}
