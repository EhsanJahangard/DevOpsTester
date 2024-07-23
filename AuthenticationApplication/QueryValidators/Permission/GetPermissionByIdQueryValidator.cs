using AuthenticationApplication.Queries.Permission;
using FluentValidation;

namespace AuthenticationApplication.QueryValidators.Permission
{
    public class GetPermissionByIdQueryValidator : AbstractValidator<GetPermissionByIdQuery>
    {
        public GetPermissionByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
        }
    }
}
