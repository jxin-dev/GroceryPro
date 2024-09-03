namespace GroceryPro.Api.Common.Models
{
    public class Error
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        public Error(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }

    public enum ErrorType 
    {
        Validation = 1,
        Notfound = 2,
        Unauthorized = 3,
        Forbidden = 4,
        InternalServerError = 5,
        Conflict = 6,
        ServiceUnavailable = 7
    }
}
