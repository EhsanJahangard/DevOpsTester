using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Role
{
    public class UpdateRoleCommand : IRequest<ResponseMessage>
    {
        public string Id { get; set; }  
        public string Name { get; set; }
        public string Description { get; set; } 
        public string? Sender {  get; set; } 
    }
}
