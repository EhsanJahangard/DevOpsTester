using FluentValidation;
using IdentityApplication.CQRS.Authentication.Queries.RolePermission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApplication.Validators.Query.RolePermission;

public class GetPermissionByRoleIdQueryValidator : AbstractValidator<GetPermissionByRoleIdQuery>
{
    public GetPermissionByRoleIdQueryValidator()
    {
        RuleFor(x => x.RoleId).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
    }
}
