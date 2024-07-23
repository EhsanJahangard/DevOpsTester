using AuthenticationApplication.Commands.Role;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Role
{
    public class UpdateRoleCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه نقش را وارد نمایید");
            RuleFor(x => x.Name).NotEmpty().WithMessage("نام نقش را وارد نمایید");
            RuleFor(x => x.Description).NotEmpty().WithMessage("توضیحات نقش را وارد نمایید");
        }
    }
}
