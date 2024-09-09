using FluentValidation;

public class QuestionPhotoCommandValidator : AbstractValidator<TestApplication.CQRS.QuestionPhoto.Commands.CreateQuestionPhotoCommand>
{
    public QuestionPhotoCommandValidator()
    {
        RuleFor(x => x.QuestionId).NotEmpty().WithMessage("سوال را مشخص کنید");
        RuleFor(x => x.Title).NotEmpty().WithMessage("عنوان عکس را مشخص کنید");
       
    }
}


