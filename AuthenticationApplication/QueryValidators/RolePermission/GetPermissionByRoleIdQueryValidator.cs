using AuthenticationApplication.Queries.RolePermission;
using FluentValidation;

namespace AuthenticationApplication.QueryValidators.RolePermission
{
    public class GetPermissionByRoleIdQueryValidator : AbstractValidator<GetPermissionByRoleIdQuery>
    {
        public GetPermissionByRoleIdQueryValidator()
        {
            RuleFor(x => x.RoleId).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
        }
    }
}
