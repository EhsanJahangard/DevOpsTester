using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Password;

namespace IdentityApplication.Validators.Command.Password;

public class ResetPasswordCommandValidator : AbstractValidator<ResetPasswordCommand>
{
    public ResetPasswordCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
    }
}