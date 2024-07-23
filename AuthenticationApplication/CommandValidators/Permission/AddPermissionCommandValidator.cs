﻿using AuthenticationApplication.Commands.Permission;
using FluentValidation;

namespace AuthenticationApplication.CommandValidators.Permission
{
    public class AddPermissionCommandValidator : AbstractValidator<AddPermissionCommand>
    {
        public AddPermissionCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("نام پرمیژن را وارد نمایید");
            RuleFor(x => x.Description).NotEmpty().WithMessage("توضیحات پرمیژن را وارد نمایید"); 
            RuleFor(x => x.ServiceType).NotEmpty().WithMessage("نوع سرویس پرمیژن را وارد نمایید"); 
        }
    }
}
