using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.Password
{
    public class ResetPasswordCommand : IRequest<ResponseMessage>
    {
        public string UserId {  get; set; }
        public string? Sender {  get; set; }
    }
}
