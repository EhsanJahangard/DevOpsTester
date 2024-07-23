using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Login
{
    public class CheckVerificationCodeCommand : IRequest<ResponseMessage>
    {
        public string Username { get; set; }    
        public string VerificationCode { get; set; }
    }
}
