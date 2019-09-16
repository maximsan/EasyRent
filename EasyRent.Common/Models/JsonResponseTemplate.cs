using System.Collections.Generic;
using System.Linq;

namespace EasyRent.Common.Models
{
    public class JsonResponseTemplate<TResponse> : JsonResponseTemplate
    {
        public new TResponse Response { get; set; }

        public JsonResponseTemplate(TResponse response, string errorMessage) : base(response, errorMessage)
        {
            Response = response;
        }

        public JsonResponseTemplate(TResponse response, List<string> errorMessages) : base(response, errorMessages)
        {
            Response = response;
        }
    }

    public class JsonResponseTemplate
    {
        public List<string> ErrorMessages { get; set; }

        public object Response { get; set; }

        public JsonResponseTemplate(object response, string errorMessage)
        {
            ErrorMessages = new List<string>
            {
                errorMessage
            };

            Response = response;
        }

        public JsonResponseTemplate(object response, IEnumerable<string> errorMessages)
        {
            ErrorMessages = errorMessages.ToList();

            Response = response;
        }
    }
}