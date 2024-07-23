using AuthenticationApplication.Commands.Role;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Role
{
    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
        }
    }
}
