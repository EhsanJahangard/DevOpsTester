using AuthenticationApplication.Commands.User;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.User
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
