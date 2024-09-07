using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.QuestionOption.Commands;

public class CreateQuestionOptionCommand : IRequest<BaseResponseDto>
{
    public string Title { get; set; }
    public Guid QuestionId { get; set; }
}
