using MediatR;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.Person.Commands;

public class CreatePersonCommand : IRequest<BaseResponseDto>
{
    public string Name { get; set; }
    public string Family { get; set; }
    public DateTime DateBirth { get; set; }
    public string Mobile { get; set; }
}
