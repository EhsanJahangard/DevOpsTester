using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.Master.Queries;

public class GetAllMasterQuery : IRequest<ResponseMessage>
{
}