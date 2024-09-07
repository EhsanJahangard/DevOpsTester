using FluentValidation;

namespace TestApplication.Validators.Test;

public class TestCommandValidator : AbstractValidator<TestApplication.CQRS.Test.Commands.CreateTestCommand>
{
    public TestCommandValidator()
    {
        RuleFor(x => x.MasterId).NotEmpty().WithMessage("استاد را مشخص کنید");
        RuleFor(x => x.TypeTest).NotEmpty().WithMessage("نوع آزمون را مشخص کنید");
    }
}


