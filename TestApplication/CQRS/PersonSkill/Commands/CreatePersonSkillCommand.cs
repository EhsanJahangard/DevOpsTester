using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.PersonSkill.Commands;

public class CreatePersonSkillCommand : IRequest<BaseResponseDto>
{
    public Guid SkillId { get; set; }
    public Guid PersonId { get; set; }
    public Guid  LevelId { get; set; }
}
