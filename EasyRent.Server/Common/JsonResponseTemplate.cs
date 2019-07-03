namespace EasyPeasyRent.Common
{
    public class JsonResponseTemplate<TResponse> : JsonResponseTemplate
    {
        public new TResponse Response { get; set; }

        public JsonResponseTemplate(TResponse response, string errorMessage) : base(response, errorMessage)
        {
            Response = response;
        }
    }

    public class JsonResponseTemplate
    {
        public string ErrorMessage { get; set; }

        public object Response { get; set; }

        public JsonResponseTemplate(object response, string errorMessage)
        {
            ErrorMessage = errorMessage;
            Response = response;
        }
    }
}