using FluentValidation;
using IdentityApplication.CQRS.Authentication.Queries.Permission;

namespace IdentityApplication.Validators.Query.Permission;

public class GetPermissionByIdQueryValidator : AbstractValidator<GetPermissionByIdQuery>
{
    public GetPermissionByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
    }
}
