
using FluentValidation;

namespace TestApplication.Validators.Photo;

public class PhotoCommandValidator : AbstractValidator<TestApplication.CQRS.Photo.Commands.CreatePhotoCommand>
{
    public PhotoCommandValidator()
    {
        RuleFor(x => x.Title).MinimumLength(2).NotEmpty().WithMessage("عنوان عکس را وارد کنید");
    }
}


