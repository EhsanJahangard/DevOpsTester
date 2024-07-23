using AuthenticationApplication.Commands.Permission;
using AuthenticationApplication.Convertors;
using AuthenticationDomain;
using AuthenticationRepository.Repositories.Interfaces;
using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.CommandHandlers
{
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

                await _unitOfWork.SaveChangesAsync();
                
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
                    return new ResponseMessage("پرمیژن وجود ندارد");

                permission.Update(request.ToModel());
                
                await _unitOfWork.SaveChangesAsync();

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
                    return new ResponseMessage("پرمیژن وجود ندارد");

                _permissionRepository.Delete(permission);

                await _unitOfWork.SaveChangesAsync(); 

                return new ResponseMessage();
            }
            catch(Exception ex) 
            {
                return new ResponseMessage(ex.Message);
            }
        }
    }
}
