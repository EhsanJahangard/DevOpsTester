using InfrastructureService;
using MediatR;

namespace AuthenticationApplication.Queries.User
{
    public class GetUserByIdQuery : IRequest<ResponseMessage>
    {
        public string Id { get; set; }
    }
}
