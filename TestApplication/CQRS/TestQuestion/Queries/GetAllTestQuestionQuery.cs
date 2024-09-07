using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.TestQuestion.Queries;

public class GetAllTestQuestionQuery : IRequest<ResponseMessage>
{
}