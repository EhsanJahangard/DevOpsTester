using AuthenticationApplication.Commands.RolePermission;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.RolePermission
{
    public class DeleteRolePermissionCommandValidator : AbstractValidator<DeleteRolePermissionCommand>
    {
        public DeleteRolePermissionCommandValidator()
        {
            RuleFor(x => x.RoleId).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
        }
    }
}
