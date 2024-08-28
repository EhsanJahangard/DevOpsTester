using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Role;

namespace IdentityApplication.Validators.Command.Role;

public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
{
    public DeleteRoleCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
    }
}
