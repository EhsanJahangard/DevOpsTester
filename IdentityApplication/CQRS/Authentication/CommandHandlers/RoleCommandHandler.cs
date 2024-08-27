using IdentityApplication.CQRS.Authentication.Commands.Role;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class RoleCommandHandler :
        IRequestHandler<AddRoleCommand, ResponseMessage>,
        IRequestHandler<UpdateRoleCommand, ResponseMessage>,
        IRequestHandler<DeleteRoleCommand, ResponseMessage>
{
    private readonly RoleManager<Role> _roleManager;

    public RoleCommandHandler(RoleManager<Role> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task<ResponseMessage> Handle(AddRoleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            bool isRoleExists = await _roleManager.RoleExistsAsync(request.Name);

            if (isRoleExists)
                return new ResponseMessage("نقش وارد شده تکراری می باشد");

            IdentityResult identityResult = await _roleManager.CreateAsync(request.ToModel());

            if (identityResult.Errors.Any())
                return new ResponseMessage("مشکلی در ایجاد نقش وجود دارد", identityResult.Errors);

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Role role = await _roleManager.FindByIdAsync(request.Id);

            if (role == null)
                return new ResponseMessage("نقش مورد نظر وجود ندارد");

            role.Update(request.ToModel());

            IdentityResult identityResult = await _roleManager.UpdateAsync(role);

            if (identityResult.Errors.Any())
                return new ResponseMessage("مشکلی در ویرایش نقش وجود دارد", identityResult.Errors);

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Role role = await _roleManager.FindByIdAsync(request.Id);

            if (role == null)
                return new ResponseMessage("نقش مورد نظر یافت نشد");

            IdentityResult identityResult = await _roleManager.DeleteAsync(role);

            if (identityResult.Errors.Any())
                return new ResponseMessage("مشکی در حذف نقش وجود دارد", identityResult.Errors);

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }
}