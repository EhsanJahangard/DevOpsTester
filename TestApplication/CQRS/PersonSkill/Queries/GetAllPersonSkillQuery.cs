using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.PersonSkill.Queries;

public class GetAllPersonSkillQuery : IRequest<ResponseMessage>
{
}