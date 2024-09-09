using FluentValidation;

public class PersonSkillCommandValidator : AbstractValidator<TestApplication.CQRS.PersonSkill.Commands.CreatePersonSkillCommand>
{
    public PersonSkillCommandValidator()
    {
        RuleFor(x => x.SkillId).NotEmpty().WithMessage("آزمون را وارد کنید");
        RuleFor(x => x.PersonId).NotEmpty().WithMessage("سوال را وارد کنید");
        RuleFor(x => x.LevelId).NotEmpty().WithMessage("سطح را وارد کنید");
    }
}


