using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Permission;

namespace IdentityApplication.Validators.Command.Permission;

public class DeletePermissionCommandValidator : AbstractValidator<DeletePermissionCommand>
{
    public DeletePermissionCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
    }
}
