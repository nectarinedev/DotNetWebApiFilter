using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetWebApiFilter.Filters;

public class LoggingFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        Console.WriteLine("Before action executed");
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine("After action executed");
    }
}