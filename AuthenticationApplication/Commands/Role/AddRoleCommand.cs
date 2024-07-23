using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Role
{
    public class AddRoleCommand : IRequest<ResponseMessage>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? Sender {  get; set; }    
    }
}
