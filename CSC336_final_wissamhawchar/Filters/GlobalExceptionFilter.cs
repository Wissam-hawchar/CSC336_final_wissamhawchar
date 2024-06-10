using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CSC336_final_wissamhawchar.Filters
{
    public class GlobalExceptionFilter:IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var statusCode = 404;

            context.Result = new ObjectResult(new
            {
                error = context.Exception.Message,
                stackTrace = context.Exception.StackTrace
            })
            {
                StatusCode = statusCode
            };
        }
    }
}
