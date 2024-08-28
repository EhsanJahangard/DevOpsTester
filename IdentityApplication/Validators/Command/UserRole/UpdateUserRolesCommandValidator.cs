using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.UserRole;

namespace IdentityApplication.Validators.Command.UserRole;

public class UpdateUserRolesCommandValidator : AbstractValidator<UpdateUserRolesCommand>
{
    public UpdateUserRolesCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
        RuleForEach(x => x.RoleIds).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
    }
}
