using FluentValidation;

public class TestQuestionCommandValidator : AbstractValidator<TestApplication.CQRS.TestQuestion.Commands.CreateTestQuestionCommand>
{
    public TestQuestionCommandValidator()
    {
        RuleFor(x => x.TestId).NotEmpty().WithMessage("آزمون را وارد کنید");
        RuleFor(x => x.QuestionId).NotEmpty().WithMessage("سوال را وارد کنید");
    }
}


