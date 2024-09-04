using FluentValidation;

namespace TestApplication.Validators.Person;


public class PersonCommandValidator : AbstractValidator<CQRS.Level.Commands.CreatePersonCommand>
{
public PersonCommandValidator()
{
    RuleFor(x => x.Family).NotEmpty().WithMessage("فامیلی را وارد کنید");
    RuleFor(x => x.Name).MinimumLength(4).WithMessage("نام را وارد کنید");
    RuleFor(x => x.Mobile).MinimumLength(4).WithMessage("موبایل را وارد کنید");
    RuleFor(x => x.Age).NotNull().WithMessage("سن را وارد کنید");

}
}
