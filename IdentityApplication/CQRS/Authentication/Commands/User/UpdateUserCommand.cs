using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Commands.User;

public class UpdateUserCommand : IRequest<ResponseMessage>
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Mobile { get; set; }
    public string? Sender { get; set; }
}
