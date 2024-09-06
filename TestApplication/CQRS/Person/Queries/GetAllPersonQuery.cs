using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.Person.Queries;

public class GetAllPersonQuery : IRequest<ResponseMessage>
{
}