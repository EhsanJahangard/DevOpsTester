using AuthenticationApplication.Commands.Password;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Password
{
    public class ChangePasswordValidator : AbstractValidator<ChangePasswordCommand>
    {
        public ChangePasswordValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("شناسه کاربر را وارد نمایید");
            RuleFor(x => x.CurrentPassword).NotEmpty().WithMessage("رمز عبور فعلی را وارد نمایید");
            RuleFor(x => x.NewPassword).NotEmpty().WithMessage("رمز عبور جدید وارد نمایید");
            RuleFor(x => x.ReNewPassword).NotEmpty().WithMessage("تکرار رمز عبور جدید وارد نمایید");
            RuleFor(x => x.NewPassword).Equal(x => x.ReNewPassword).WithMessage("رمز عبور جدید و تکرار آن باید یکسان باشد");
        }
    }
}
