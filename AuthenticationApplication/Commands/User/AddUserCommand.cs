using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Commands.User
{
    public class AddUserCommand : IRequest<ResponseMessage>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string? Sender { get; set; }
    }
}
