using FluentValidation;
using IdentityApplication.CQRS.Authentication.Queries.Role;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApplication.Validators.Query.Role;

public class GetRoleByIdeQueryValidator : AbstractValidator<GetRoleByIdQuery>
{
    public GetRoleByIdeQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
        RuleFor(x => x.Id).Must(x => Guid.TryParse(x, out Guid result)).WithMessage("نوع پارامتر شناسه کاربر صحیح نمی باشد");
    }
}
