using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Login;

namespace IdentityApplication.Validators.Command.Login;

public class LoginCommandValidator : AbstractValidator<SendVerificationCodeCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.Username).NotEmpty().WithMessage("نام کاربری را وارد نمایید");
        RuleFor(x => x.Password).NotEmpty().WithMessage("رمز عبور را وارد نمایید");
    }
}
