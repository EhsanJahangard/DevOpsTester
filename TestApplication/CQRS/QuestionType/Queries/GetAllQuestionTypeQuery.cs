using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.QuestionType.Queries;

public class GetAllQuestionTypeQuery : IRequest<ResponseMessage>
{
}