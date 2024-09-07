
using FluentValidation;

namespace TestApplication.Validators.QuestionOption;

public class QuestionOptionCommandValidator : AbstractValidator<TestApplication.CQRS.QuestionOption.Commands.CreateQuestionOptionCommand>
{
    public QuestionOptionCommandValidator()
    {
        RuleFor(x => x.Title).MinimumLength(2).NotEmpty().WithMessage("مورد را وارد کنید");
    }
}


