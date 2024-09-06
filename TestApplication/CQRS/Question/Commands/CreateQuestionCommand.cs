using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.Question.Commands;

public class CreateQuestionCommand : IRequest<BaseResponseDto>
{
    public string Letter { get; set; }
    public string Answer { get; set; }
    public Guid LevelId { get; set; }
    public Guid QuestionTypeId { get; set; }
}
