using MediatR;
using System.ComponentModel.DataAnnotations;
using TestApplication.DTOs.Common;

namespace TestApplication.CQRS.Test.Commands;

public class CreateTestCommand : IRequest<BaseResponseDto>
{
    public string Title { get; set; }
    public DateTime? DateTest { get; set; }
    public string Description { get; set; }
    [AllowedValues("OnSite", "Remote", "Other")]
    public string TypeTest { get; set; } = "Remote";
    public DateTime? ExpirtionTest { get; set; }
    public byte? LengthMinuteTest { get; set; } = 10;
    public Guid MasterId { get; set; }
}
