using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.QuestionPhoto.Queries;

public class GetAllQuestionPhotoQuery : IRequest<ResponseMessage>
{
}