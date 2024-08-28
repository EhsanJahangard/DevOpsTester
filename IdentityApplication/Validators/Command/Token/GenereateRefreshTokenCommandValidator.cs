using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Token;

namespace IdentityApplication.Validators.Command.Token;

public class GenereateRefreshTokenCommandValidator : AbstractValidator<GenereateRefreshTokenCommand>
{
    public GenereateRefreshTokenCommandValidator()
    {
        RuleFor(x => x.AccessToken).NotEmpty().WithMessage("توکن را وارد نمایید");
        RuleFor(x => x.RefreshToken).NotEmpty().WithMessage("رفرش توکن را وارد نمایید");
    }
}
