using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.Skill.Commands;

public class CreateSkillCommand : IRequest<BaseResponseDto>
{
    public string Title { get; set; }
}
