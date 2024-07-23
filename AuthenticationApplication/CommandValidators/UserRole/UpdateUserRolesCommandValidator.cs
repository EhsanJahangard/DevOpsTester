using AuthenticationApplication.Commands.UserRole;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.UserRole
{
    public class UpdateUserRolesCommandValidator : AbstractValidator<UpdateUserRolesCommand>
    {
        public UpdateUserRolesCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
            RuleForEach(x => x.RoleIds).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
        }
    }
}
