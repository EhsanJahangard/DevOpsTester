using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.Test.Queries;

public class GetAllTestQuery : IRequest<ResponseMessage>
{
}