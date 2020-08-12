using EasyRent.Common.Constants;
using EasyRent.Common.Extensions;
using EasyRent.Data.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EasyRent.BusinessLayer.Extensions
{
    public static class ValidatorExtentions
    {
        public static IRuleBuilder<T, string> UserMustExist<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                               UserManager<User> userManager)
        {
            return ruleBuilder.Custom((userNameOrEmail, context) =>
            {
                if (userManager is null)
                {
                    context.AddFailure(ErrorMessages.ServerError);

                    return;
                }

                if (!string.IsNullOrWhiteSpace(userNameOrEmail) &&
                    userManager.FindByUserNameOrEmail(userNameOrEmail) is null)
                {
                    context.AddFailure(ErrorMessages.UserNotExist);
                }
            });
        }

        public static IRuleBuilder<T, string> UserNotMustExist<T>(this IRuleBuilder<T, string> ruleBuilder,
                                                                  UserManager<User> userManager)
        {
            return ruleBuilder.Custom((userNameOrEmail, context) =>
            {
                if (userManager is null)
                {
                    context.AddFailure(ErrorMessages.ServerError);

                    return;
                }

                if (!string.IsNullOrWhiteSpace(userNameOrEmail) &&
                    !(userManager.FindByUserNameOrEmail(userNameOrEmail) is null))
                {
                    context.AddFailure(ErrorMessages.UserExists);
                }
            });
        }

        public static bool ValidatePassword(this string password,
                                            string userNameOrEmail,
                                            UserManager<User> userManager)
        {
            if (userManager is null)
            {
                return false;
            }

            if (!string.IsNullOrWhiteSpace(userNameOrEmail))
            {
                User user = userManager.FindByUserNameOrEmail(userNameOrEmail);

                if (user is null)
                {
                    return false;
                }

                Task<bool> checkPasswordTask = userManager.CheckPasswordAsync(user, password);

                checkPasswordTask.Wait();

                return checkPasswordTask.Result;
            }

            return false;
        }

        public static IRuleBuilder<T, string> NotNullOrEmpty<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Custom((prop, context) =>
            {
                if (prop.IsNullOrWhiteSpace())
                {
                    context.AddFailure(context.PropertyName, $"{context.DisplayName} cannot be empty.");
                }
            });
        }
    }
}