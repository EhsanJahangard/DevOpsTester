
using FluentValidation;

namespace TestApplication.Validators.Skill;

public class QuestionTypeCommandValidator : AbstractValidator<TestApplication.CQRS.QuestionType.Commands.CreateQuestionTypeCommand>
{
    public QuestionTypeCommandValidator()
    {
        RuleFor(x => x.Title).MinimumLength(2).NotEmpty().WithMessage("نوع سوال را وارد کنید");
    }
}


