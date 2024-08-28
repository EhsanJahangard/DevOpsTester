using IdentityApplication.CQRS.Authentication.Queries.Permission;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.QueryHandlers;

public class PermissionQueryHandler :
        IRequestHandler<GetAllPermissionQuery, ResponseMessage>,
        IRequestHandler<GetPermissionByIdQuery, ResponseMessage>
{
    private readonly IPermissionRepository _permissionRepository;

    public PermissionQueryHandler(IPermissionRepository permissionRepository)
    {
        _permissionRepository = permissionRepository;
    }

    public async Task<ResponseMessage> Handle(GetAllPermissionQuery request, CancellationToken cancellationToken)
    {
        try
        {
            List<Permission> permissions = await _permissionRepository.GetAllAsync();

            return new ResponseMessage(permissions);
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(GetPermissionByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            Permission permission = await _permissionRepository.GetByIdAsync(Guid.Parse(request.Id));

            if (permission == null)
                return new ResponseMessage("پرمیژن وجود ندارد");

            return new ResponseMessage(permission);
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }
}
