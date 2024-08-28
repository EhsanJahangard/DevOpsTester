using IdentityApplication.Contracts.Repositories;
using IdentityApplication.Contracts.UnitOfWork;
using IdentityApplication.CQRS.Authentication.Commands.RolePermission;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class RolePermissionCommandHandler :
        IRequestHandler<AddRolePermissionCommand, ResponseMessage>,
        IRequestHandler<UpdateRolePermissionCommand, ResponseMessage>,
        IRequestHandler<DeleteRolePermissionCommand, ResponseMessage>
{
    private readonly RoleManager<Role> _roleManager;
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public RolePermissionCommandHandler(RoleManager<Role> roleManager, IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _roleManager = roleManager;
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResponseMessage> Handle(AddRolePermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Role role = await _roleManager.Roles.Where(x => x.Id == request.RoleId).Include(x => x.Permissions).FirstOrDefaultAsync();

            if (role == null)
                return new ResponseMessage("نقش وجود ندارد");

            if (role.Permissions.Any())
                return new ResponseMessage("نقش پرمیژن دارد");

            List<Permission> permissions = await _permissionRepository.GetByIdsAsync(request.PermissionIds);

            if (!permissions.Any())
                return new ResponseMessage("پرمیژن وجود ندارد");

            role.AddPermissions(permissions);

            await _unitOfWork.Save();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }

    }

    public async Task<ResponseMessage> Handle(UpdateRolePermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Role role = await _roleManager.Roles.Where(x => x.Id == request.RoleId).Include(x => x.Permissions).FirstOrDefaultAsync();

            if (role == null)
                return new ResponseMessage("نقش وجود ندارد");

            if (!role.Permissions.Any())
                return new ResponseMessage("نقش پرمیژن ندارد");

            List<Permission> permissions = await _permissionRepository.GetByIdsAsync(request.PermissionIds);

            if (!permissions.Any())
                return new ResponseMessage("پرمیژن وجود ندارد");

            role.Permissions.Clear();

            role.AddPermissions(permissions);

            await _unitOfWork.Save();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(DeleteRolePermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Role role = await _roleManager.Roles.Where(x => x.Id == request.RoleId).Include(x => x.Permissions).FirstOrDefaultAsync();

            if (role == null)
                return new ResponseMessage("نقش وجود ندارد");

            if (!role.Permissions.Any())
                return new ResponseMessage("نقش پرمیژن ندارد");

            role.Permissions.Clear();

            await _unitOfWork.Save();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }
}