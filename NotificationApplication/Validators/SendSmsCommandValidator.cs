using FluentValidation;
using NotificationApplication.Commands;

namespace NotificationApplication.Validators;

public class SendSmsCommandValidator : AbstractValidator<SendSmsCommand>
{
    public SendSmsCommandValidator()
    {
        RuleFor(x => x.MobileNumber).NotEmpty().WithMessage("شماره موبایل را وارد نمایید");
        RuleFor(x => x.Message).NotEmpty().WithMessage("پیغام را وارد نمایید");
    }
}
