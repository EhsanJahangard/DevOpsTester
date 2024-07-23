using AuthenticationApplication.Commands.Password;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Password
{
    public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
    {
        public ResetPasswordCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
        }
    }
}
