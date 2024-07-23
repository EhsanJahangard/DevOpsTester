using AuthenticationApplication.Commands.Role;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Role
{
    public class AddRoleCommandValidator : AbstractValidator<AddRoleCommand>
    {
        public AddRoleCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("نام نقش را وارد نمایید");
            RuleFor(x => x.Description).NotEmpty().WithMessage("توضیحات نقش را وارد نمایید");
        }
    }
}
