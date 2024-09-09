using InfrastructureService;
using MediatR;

namespace TestApplication.CQRS.Skill.Queries;

public class GetAllSkillQuery : IRequest<ResponseMessage>
{
}