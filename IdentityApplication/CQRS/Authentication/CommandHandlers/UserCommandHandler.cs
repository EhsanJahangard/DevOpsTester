using IdentityApplication.CQRS.Authentication.Commands.User;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class UserCommandHandler :
       IRequestHandler<AddUserCommand, ResponseMessage>,
       IRequestHandler<UpdateUserCommand, ResponseMessage>,
       IRequestHandler<DeleteUserCommand, ResponseMessage>
{
    private readonly UserManager<User> _userManager;
    private readonly IdentityDBContext _authenticationContext;
    public UserCommandHandler(UserManager<User> userManager, IdentityDBContext authenticationContext)
    {
        _userManager = userManager;
        _authenticationContext = authenticationContext;
    }

    public async Task<ResponseMessage> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            if (await _userManager.FindByEmailAsync(request.Email) != null || await _userManager.FindByNameAsync(request.UserName) != null)
                return new ResponseMessage("کاربر قبلا در سامانه ثبت شده است");

            IdentityResult identityResult = await _userManager.CreateAsync(request.ToModel(), request.Password);

            if (identityResult.Errors.Any())
                return new ResponseMessage("مشکلی در ثبت کاربر وجود دارد", identityResult.Errors);

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userManager.FindByIdAsync(request.Id);

            if (user == null)
                return new ResponseMessage("کاربر مورد نظر وجود ندارد");

            user.Update(request.ToModel());

            int result = await _authenticationContext.SaveChangesAsync();

            if (result != 1)
                return new ResponseMessage("مشکلی در ویرایش اطلاعات کاربر وجود دارد");

            return new ResponseMessage();

        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userManager.FindByIdAsync(request.Id);

            if (user == null)
                return new ResponseMessage("کاربر مورد نظر وجود ندارد");

            IdentityResult identityResult = await _userManager.DeleteAsync(user);

            if (identityResult.Errors.Any())
                return new ResponseMessage("مشلکی در حذف کاربر وجود دارد", identityResult.Errors);

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }

    }
}