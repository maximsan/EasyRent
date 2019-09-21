using System;
using System.Collections.Generic;
using EasyRent.Common.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EasyRent.Common.Filters
{
    public class GlobalExceptionFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (!context.ExceptionHandled)
            {
                context.Result = new JsonResult(new JsonResponseTemplate(false, GetErrorMessages(context.Exception)));
            }
        }

        private List<string> GetErrorMessages(Exception exception, List<string> errorList = null)
        {
            errorList = errorList ?? new List<string>();

            if (!string.IsNullOrEmpty(exception.Message))
            {
                errorList.Add(exception.Message);
            }

            if (!(exception.InnerException is null))
            {
                errorList.AddRange(GetErrorMessages(exception.InnerException, errorList));
            }

            return errorList;
        }
    }
}
