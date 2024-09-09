using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.QuestionPhoto.Commands;

public class CreateQuestionPhotoCommand : IRequest<BaseResponseDto>
{
    public string Title { get; set; }
    public Guid QuestionId { get; set; }
}
