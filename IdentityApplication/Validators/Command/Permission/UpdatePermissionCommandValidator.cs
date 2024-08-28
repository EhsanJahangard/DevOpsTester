﻿using FluentValidation;
using IdentityApplication.CQRS.Authentication.Commands.Permission;

namespace IdentityApplication.Validators.Command.Permission;

public class UpdatePermissionCommandValidator : AbstractValidator<UpdatePermissionCommand>
{
    public UpdatePermissionCommandValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("شناسه پرمیژن را وارد نمایید");
        RuleFor(x => x.Name).NotEmpty().WithMessage("نام پرمیژن را وارد نمایید");
        RuleFor(x => x.Description).NotEmpty().WithMessage("توضیحات پرمیژن را وارد نمایید");
        RuleFor(x => x.ServiceType).NotEmpty().WithMessage("نوع سرویس پرمیژن را وارد نمایید");
    }
}
