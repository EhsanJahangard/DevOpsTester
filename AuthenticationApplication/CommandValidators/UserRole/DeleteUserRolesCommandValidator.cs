using AuthenticationApplication.Commands.UserRole;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.UserRole
{
    public class DeleteUserRolesCommandValidator : AbstractValidator<DeleteUserRolesCommand>
    {
        public DeleteUserRolesCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
        }
    }
}
