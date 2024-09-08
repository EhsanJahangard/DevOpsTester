using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.QuestionType.Commands;

public class CreateQuestionTypeCommand : IRequest<BaseResponseDto>
{
    public string Title { get; set; }
}
