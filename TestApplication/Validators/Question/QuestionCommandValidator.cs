using FluentValidation;

namespace TestApplication.Validators.Question;

public class QuestionCommandValidator : AbstractValidator<CQRS.Question.Commands.CreateQuestionCommand>
{
    public QuestionCommandValidator()
    {
        RuleFor(x => x.Letter).MinimumLength(4).NotEmpty().WithMessage("سوال را وارد کنید");
        RuleFor(x => x.Answer).MinimumLength(2).WithMessage("جواب را وارد کنید");


    }
}


