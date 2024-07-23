using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.User
{
    public class GetAllUserQuery : IRequest<ResponseMessage>
    {
    }
}
