using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetWebApiFilter.Filters;

public class LoggingAsyncFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(
        ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine("Before action executed Async");
        await next();
        Console.WriteLine("After action executed Async");
    }
}