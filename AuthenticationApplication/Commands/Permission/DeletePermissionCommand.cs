using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Permission
{
    public class DeletePermissionCommand : IRequest<ResponseMessage>
    {
        public string Id { get; set; }  
    }
}
