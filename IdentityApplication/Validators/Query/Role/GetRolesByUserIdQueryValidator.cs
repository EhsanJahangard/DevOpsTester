using FluentValidation;
using IdentityApplication.CQRS.Authentication.Queries.UserRole;

namespace IdentityApplication.Validators.Query.Role;

public class GetRolesByUserIdQueryValidator : AbstractValidator<GetRolesByUserIdQuery>
{
    public GetRolesByUserIdQueryValidator()
    {
        RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
        RuleFor(x => x.UserId).Must(x => Guid.TryParse(x, out Guid result)).WithMessage("نوع پارامتر شناسه کاربر صحیح نمی باشد");
    }
}
