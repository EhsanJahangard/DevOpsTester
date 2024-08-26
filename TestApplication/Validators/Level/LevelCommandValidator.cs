using FluentValidation;

namespace TestApplication.Validators.Level
{
    public class LevelCommandValidator : AbstractValidator<CQRS.Level.Commands.CreateLevelCommand>
    {
        public LevelCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("عنوان را وارد کنید");
            RuleFor(x => x.Title).MinimumLength(4).WithMessage("عنوان را وارد کنید");
            
        }
    }
}
