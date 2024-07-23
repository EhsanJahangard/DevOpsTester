using AuthenticationDomain;
using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Password
{
    public class ChangePasswordCommand : IRequest<ResponseMessage>
    {
        public string UserId { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ReNewPassword { get; set; }   
        public string? Sender {  get; set; } 
    }
}
