using AuthenticationApplication.Commands.Token;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Token
{
    public class GenereateRefreshTokenCommandValidator : AbstractValidator<GenereateRefreshTokenCommand>
    {
        public GenereateRefreshTokenCommandValidator()
        {
            RuleFor(x => x.AccessToken).NotEmpty().WithMessage("توکن را وارد نمایید");
            RuleFor(x => x.RefreshToken).NotEmpty().WithMessage("رفرش توکن را وارد نمایید");
        }
    }
}
