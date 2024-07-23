using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Login
{
    public class SendVerificationCodeCommand : IRequest<ResponseMessage>
    {
        public string Username { get; set; }   
        public string Password { get; set; }
    }
}
