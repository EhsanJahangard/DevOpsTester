using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.RolePermission;

namespace IdentityApplication.Validators.Command.RolePermission;

public class UpdateRolePermissionCommandValidator : AbstractValidator<UpdateRolePermissionCommand>
{
    public UpdateRolePermissionCommandValidator()
    {
        RuleFor(x => x.RoleId).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
        RuleForEach(x => x.PermissionIds).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
    }
}