using EasyRent.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace EasyRent.Server.Common.Extentions
{
    public static class ValidatorExtentions
    {
        public static IRuleBuilder<T, string> UserExists<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                            UserManager<User> userManager)
        {
            return ruleBuilder.Custom((userNameOrEmail, context) =>
            {
                if (userManager is null)
                {
                    context.AddFailure("User Manager cannot be empty.");
                }

                if (!(userManager.FindByUserNameOrEmail(userNameOrEmail) is null))
                {
                    context.AddFailure("This user already exists.");
                }
            });
        }
    }
}