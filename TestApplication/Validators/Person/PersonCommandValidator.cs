using FluentValidation;

namespace TestApplication.Validators.Person;


public class PersonCommandValidator : AbstractValidator<CQRS.Person.Commands.CreatePersonCommand>
{
    public PersonCommandValidator()
    {
        RuleFor(x => x.Family).MinimumLength(4).NotEmpty().WithMessage("فامیلی را وارد کنید");
        RuleFor(x => x.Name).MinimumLength(2).WithMessage("نام را وارد کنید");
        RuleFor(x => x.Mobile).MinimumLength(11).WithMessage("موبایل را وارد کنید");
        RuleFor(x => x.DateBirth).NotNull().WithMessage("سن را وارد کنید");

    }
}
