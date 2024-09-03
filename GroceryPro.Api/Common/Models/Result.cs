namespace GroceryPro.Api.Common.Models
{
    public class Result
    {
        public bool IsSuccess { get; private set; }
        public bool IsFailure => !IsSuccess;
        public object Value { get; private set; }
        public Error Error { get; private set; }
        public ErrorType ErrorType { get; private set; }
        private Result(bool isSuccess, object value, Error error, ErrorType errorType)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
            ErrorType = errorType;
        }

        public static Result Success(object value)
        {
            return new Result(true, value, default!, default!);
        }

        public static Result Failure(Error error, ErrorType errorType)
        {
            return new Result(false, default!, error, errorType);
        }

    }
}
