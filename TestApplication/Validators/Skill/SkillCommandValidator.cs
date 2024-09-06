
using FluentValidation;

namespace TestApplication.Validators.Skill;

public class SkillCommandValidator : AbstractValidator<TestApplication.CQRS.Skill.Commands.CreateSkillCommand>
{
    public SkillCommandValidator()
    {
        RuleFor(x => x.Title).MinimumLength(2).NotEmpty().WithMessage("مهارت را وارد کنید");
    }
}


