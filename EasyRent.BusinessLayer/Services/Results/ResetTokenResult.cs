namespace EasyRent.BusinessLayer.Services.Results
{
    public class ResetTokenResult : BaseResult<string>
    {
        public ResetTokenResult(bool isSuccess, string result = null) : base(isSuccess, result)
        {
        }
    }
}