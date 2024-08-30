using IdentityApplication.CQRS.Authentication.Commands.Password;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class PasswordCommandHandler :
      IRequestHandler<ChangePasswordCommand, ResponseMessage>,
      IRequestHandler<ResetPasswordCommand, ResponseMessage>

{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;
    public PasswordCommandHandler(UserManager<User> userManager, IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }

    public async Task<ResponseMessage> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userManager.FindByIdAsync(request.UserId);

            if (user == null)
                return new ResponseMessage("کاربر مورد نظر وجود ندارد");

            user.Editor = request.Sender;
            user.UpdateDate = DateTime.Now;

            IdentityResult identityResult = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

            if (identityResult.Errors.Any())
                return new ResponseMessage("مشکلی در تغییر رمز عبور وجود دارد", identityResult.Errors);

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        try
        {
            User user = await _userManager.FindByIdAsync(request.UserId);

            if (user == null)
                return new ResponseMessage("کاربر مورد نظر وجود ندارد");

            IdentityResult identityResult = await _userManager.RemovePasswordAsync(user);

            if (identityResult.Succeeded)
            {
                user.Editor = request.Sender;
                user.UpdateDate = DateTime.Now;

                identityResult = await _userManager.AddPasswordAsync(user, _configuration["DefaultPassword"]);

                if (identityResult.Errors.Any())
                    return new ResponseMessage("مشکلی در تغییر رمز عبور به حالت پیش فرض وجود دارد", identityResult.Errors);

                return new ResponseMessage();
            }

            return new ResponseMessage("مشکلی در تغییر رمز عبور به حالت پیش فرض وجود دارد", identityResult.Errors);
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }
}