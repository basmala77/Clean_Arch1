using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AccessData.Middleware
{
    public class GlobalExceptionHandler: IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
           var problem = new ProblemDetails
            {
                Title = "An error occurred",
                Detail = exception.Message,
                Status = StatusCodes.Status500InternalServerError,
                Type = "https://httpstatuses.org/500"
            };
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await httpContext.Response.WriteAsJsonAsync(problem, cancellationToken);
            return true;
        }
    }
}
