using GroceryPro.Api.Common.Models;

namespace GroceryPro.Api.Common.Extensions
{
    public static class ResultExtensions
    {
        public static T Match<T>(this Result result, Func<T> onSuccess, Func<Error, T> onFailure)
        {
            return result.IsSuccess ? onSuccess() : onFailure(result.Error);
        }


        #region other way...
        //public static IResult ToProblemDetails(this Result result)
        //{

        //    return Results.Problem(
        //        statusCode: GetStatusCode(result.Error.Type),
        //        title: GetTitle(result.Error.Type),
        //        type: GetType(result.Error.Type),
        //        extensions: new Dictionary<string, object?>
        //        {
        //            {
        //                "errors", new[] { result.Error }
        //            }
        //        });
        //}

        //internal static int GetStatusCode(ErrorType errorType)
        //{
        //    return errorType switch
        //    {
        //        ErrorType.Notfound => StatusCodes.Status404NotFound,
        //        _ => StatusCodes.Status500InternalServerError
        //    };
        //}

        //internal static string GetTitle(ErrorType errorType)
        //{
        //    return errorType switch
        //    {
        //        ErrorType.Notfound => "Not Found",
        //        _ => "Server Failure"
        //    };
        //}

        //internal static string GetType(ErrorType errorType)
        //{
        //    return errorType switch
        //    {
        //        ErrorType.Notfound => "https://api.yourdomain.com/errors/not-found",
        //        _ => "https://api.yourdomain.com/errors/internal-server-error"
        //    };
        //}
        #endregion

    }
}
