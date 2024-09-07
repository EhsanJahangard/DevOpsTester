using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.TestQuestion.Commands;

public class CreateTestQuestionCommand : IRequest<BaseResponseDto>
{
    public Guid TestId { get; set; }
    public Guid QuestionId { get; set; }
}
