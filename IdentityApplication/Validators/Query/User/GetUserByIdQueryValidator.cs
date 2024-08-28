using FluentValidation;
using IdentityApplication.CQRS.Authentication.Queries.User;

namespace IdentityApplication.Validators.Query.User;

public class GetUserByIdQueryValidator : AbstractValidator<GetUserByIdQuery>
{
    public GetUserByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
        RuleFor(x => x.Id).Must(x => Guid.TryParse(x, out Guid result)).WithMessage("نوع پارامتر شناسه کاربر صحیح نمی باشد");
    }
}
