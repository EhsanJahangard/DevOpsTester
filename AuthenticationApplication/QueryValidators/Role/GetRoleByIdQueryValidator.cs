using AuthenticationApplication.Queries.Role;
using FluentValidation;

namespace AuthenticationApplication.QueryValidators.Role
{
    public class GetRoleByIdeQueryValidator : AbstractValidator<GetRoleByIdQuery>
    {
        public GetRoleByIdeQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
            RuleFor(x => x.Id).Must(x => Guid.TryParse(x, out Guid result)).WithMessage("نوع پارامتر شناسه کاربر صحیح نمی باشد");
        }
    }
}
