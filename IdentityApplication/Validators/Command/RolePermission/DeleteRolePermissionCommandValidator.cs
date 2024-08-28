using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.RolePermission;

namespace IdentityApplication.Validators.Command.RolePermission;

public class DeleteRolePermissionCommandValidator : AbstractValidator<DeleteRolePermissionCommand>
{
    public DeleteRolePermissionCommandValidator()
    {
        RuleFor(x => x.RoleId).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
    }
}
