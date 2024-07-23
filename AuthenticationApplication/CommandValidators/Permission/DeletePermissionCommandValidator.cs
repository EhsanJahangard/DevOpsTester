using AuthenticationApplication.Commands.Permission;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Permission
{
    public class DeletePermissionCommandValidator : AbstractValidator<DeletePermissionCommand>
    {
        public DeletePermissionCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
        }
    }
}
