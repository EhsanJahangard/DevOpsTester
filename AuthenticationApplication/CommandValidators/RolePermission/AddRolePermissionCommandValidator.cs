using AuthenticationApplication.Commands.RolePermission;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.RolePermission
{
    public class AddRolePermissionCommandValidator : AbstractValidator<AddRolePermissionCommand>
    {
        public AddRolePermissionCommandValidator()
        {
            RuleFor(x => x.RoleId).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
            RuleForEach(x => x.PermissionIds).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
        }
    }
}
