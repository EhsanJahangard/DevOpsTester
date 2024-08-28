using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Role;

namespace IdentityApplication.Validators.Command.Role;

public class AddRoleCommandValidator : AbstractValidator<AddRoleCommand>
{
    public AddRoleCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("نام نقش را وارد نمایید");
        RuleFor(x => x.Description).NotEmpty().WithMessage("توضیحات نقش را وارد نمایید");
    }
}
