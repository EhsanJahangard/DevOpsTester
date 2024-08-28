using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Queries.User;

public class GetUserByIdQuery : IRequest<ResponseMessage>
{
    public string Id { get; set; }
}
