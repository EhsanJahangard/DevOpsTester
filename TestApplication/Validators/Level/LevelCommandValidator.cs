using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Validators.Level
{
    internal class LevelCommandValidator : AbstractValidator<CQRS.Level.Commands.CreateLevelCommand>
    {
        public LevelCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("عنوان را وارد کنید");
            
        }
    }
}
