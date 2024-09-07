using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.Photo.Commands;

public class CreatePhotoCommand : IRequest<BaseResponseDto>
{
    public string Title { get; set; }
    public string Url { get; set; }
}
