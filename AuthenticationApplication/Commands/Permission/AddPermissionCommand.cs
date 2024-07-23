using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Permission
{
    public class AddPermissionCommand : IRequest<ResponseMessage>
    {
        public string Name { get; set; }    
        public string Description { get; set; }
        public string ServiceType { get; set; }
        public string? Sender { get; set; }  
    }
}
