using IdentityApplication.Contracts.Repositories;
using IdentityApplication.Contracts.UnitOfWork;
using IdentityApplication.Convertors;
using IdentityApplication.CQRS.Authentication.Commands.Permission;
using IdentityDomain.Models;
using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.CommandHandlers;

public class PermissionCommandHandler :
      IRequestHandler<AddPermissionCommand, ResponseMessage>,
      IRequestHandler<UpdatePermissionCommand, ResponseMessage>,
      IRequestHandler<DeletePermissionCommand, ResponseMessage>
{
    private readonly IPermissionRepository _permissionRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PermissionCommandHandler(IPermissionRepository permissionRepository, IUnitOfWork unitOfWork)
    {
        _permissionRepository = permissionRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResponseMessage> Handle(AddPermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _permissionRepository.AddAsync(request.ToModel());

            await _unitOfWork.Save();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(UpdatePermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Permission permission = await _permissionRepository.GetByIdAsync(Guid.Parse(request.Id));

            if (permission == null)
                return new ResponseMessage("مجوز دسترسی وجود ندارد");

            permission.Update(request.ToModel());

            await _unitOfWork.Save();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }

    public async Task<ResponseMessage> Handle(DeletePermissionCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Permission permission = await _permissionRepository.GetByIdAsync(Guid.Parse(request.Id));

            if (permission == null)
                return new ResponseMessage("مجوز دسترسی وجود ندارد");

            _permissionRepository.Delete(permission);

            await _unitOfWork.Save();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.Message);
        }
    }
}