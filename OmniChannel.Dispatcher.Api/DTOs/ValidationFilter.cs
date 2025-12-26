using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OmniChannel.Dispatcher.Api.DTOs
{
    public class ValidationFilter<T> : IAsyncActionFilter where T : class
    {
        private readonly IValidator<T> _validator;

        public ValidationFilter(IValidator<T> validator)
        {
            _validator = validator;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            
            var model = context.ActionArguments.Values.OfType<T>().FirstOrDefault();

            if (model is not null)
            {
                var result = await _validator.ValidateAsync(model);
                if (!result.IsValid)
                {
                    context.Result = new BadRequestObjectResult(result.ToDictionary());
                    return;
                }
            }

            await next();
        }
    }
}
