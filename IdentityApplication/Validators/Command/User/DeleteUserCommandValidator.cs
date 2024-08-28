using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.User;

namespace IdentityApplication.Validators.Command.User;

public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
{
    public DeleteUserCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
    }
}
