using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.Photo.Queries;

public class GetAllPhotoQuery : IRequest<ResponseMessage>
{
}