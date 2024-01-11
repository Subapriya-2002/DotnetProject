using Microsoft.AspNetCore.Mvc.Filters;

namespace ExampleMVC.Filters
{
    public class Filter : ActionFilterAttribute
    {
     public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("ONaction executed");
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
             Console.WriteLine("ONaction executing");
        }
}
}
