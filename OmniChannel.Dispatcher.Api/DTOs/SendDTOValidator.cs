using FluentValidation;

namespace OmniChannel.Dispatcher.Api.DTOs
{
    public class SendDTOValidator : AbstractValidator<SendDTO>
    {
        private string MINIMUM_LENGHT = "This parameter has to be a minimum length!";
        private string NOT_EMPTY = "This parameter is required!";
        public SendDTOValidator()
        {
            RuleFor(x => x.Channel).NotEmpty().WithMessage(NOT_EMPTY).MinimumLength(3).WithMessage(MINIMUM_LENGHT);
            RuleFor(x => x.Message).NotEmpty().WithMessage(NOT_EMPTY).MinimumLength(3).WithMessage(MINIMUM_LENGHT);
        }
    }
}
