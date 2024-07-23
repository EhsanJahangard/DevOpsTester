using AuthenticationApplication.Commands.Login;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Login
{
    public class LoginCommandValidator : AbstractValidator<SendVerificationCodeCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(x=>x.Username).NotEmpty().WithMessage("نام کاربری را وارد نمایید");
            RuleFor(x => x.Password).NotEmpty().WithMessage("رمز عبور را وارد نمایید");
        }
    }
}
