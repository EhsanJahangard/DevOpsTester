using InfrastructureService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityApplication.CQRS.Authentication.Commands.Password;

public class ChangePasswordCommand : IRequest<ResponseMessage>
{
    public string UserId { get; set; }
    public string CurrentPassword { get; set; }
    public string NewPassword { get; set; }
    public string ReNewPassword { get; set; }
    public string? Sender { get; set; }
}
