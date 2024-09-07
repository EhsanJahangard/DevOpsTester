using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.QuestionOption.Queries;

public class GetAllQuestionOptionQuery : IRequest<ResponseMessage>
{
}