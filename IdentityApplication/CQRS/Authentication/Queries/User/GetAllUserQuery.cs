using InfrastructureService;
using MediatR;

namespace IdentityApplication.CQRS.Authentication.Queries.User;

public class GetAllUserQuery : IRequest<ResponseMessage>
{
}
