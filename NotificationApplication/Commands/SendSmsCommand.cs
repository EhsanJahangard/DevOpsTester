using InfrastructureService;
using MediatR;

namespace NotificationApplication.Commands;

public class SendSmsCommand : IRequest<ResponseMessage>
{
    public string MobileNumber { get; set; }
    public string Message { get; set; }
}
