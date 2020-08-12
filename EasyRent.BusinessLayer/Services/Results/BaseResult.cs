namespace EasyRent.BusinessLayer.Services.Results
{
    public abstract class BaseResult<T>
    {
        public bool IsSuccess { get; set; }
        public T Result { get; set; }

        public BaseResult(bool isSuccess, T result = default)
        {
            IsSuccess = isSuccess;
            Result = result;
        }
    }
}