using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.UserRole;

namespace IdentityApplication.Validators.Command.UserRole;

public class DeleteUserRolesCommandValidator : AbstractValidator<DeleteUserRolesCommand>
{
    public DeleteUserRolesCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
    }
}
