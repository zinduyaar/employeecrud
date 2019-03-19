using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrud.API.Attributes
{
    public class ExceptionHandlerFilterAttribute : ExceptionFilterAttribute
    {
        public ExceptionHandlerFilterAttribute()
        {

        }
        public override void OnException(ExceptionContext context)
        {
            if(context.Exception is Exception)
            {
                context.Result = new BadRequestObjectResult(context.Exception.Message);
            }
        }
    }
}
