using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.Question.Queries;

public class GetAllQuestionQuery : IRequest<ResponseMessage>
{
}