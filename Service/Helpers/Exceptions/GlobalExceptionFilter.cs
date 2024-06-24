using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Service.Helpers.Exceptions
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = context.Exception switch
            {
                NotFoundException => StatusCodes.Status404NotFound,

                UnauthorizedAccessException => StatusCodes.Status401Unauthorized,

                _ => StatusCodes.Status500InternalServerError
            };

            context.Result = new ObjectResult(new
            {
                error = context.Exception.Message,
                //stackTrace = context.Exception.StackTrace
            })
            {
                StatusCode = statusCode
            };
        }
    }
}
