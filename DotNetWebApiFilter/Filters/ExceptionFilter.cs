using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetWebApiFilter.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        if (context.Exception is Exception)
        {
            Console.WriteLine("Exception found");
            context.Result = new BadRequestResult();
        }
    }
}