using NotificationApplication.Commands;
using NotificationDomain.Models;

namespace NotificationApplication.Convertors;

public static class ToModels
{
    public static Sms ToModel(this SendSmsCommand command, string sendResultCode)
    {
        var sms = new Sms()
        {
          
            MobileNumber = command.MobileNumber,
            Message = command.Message,
            SendResultCode = sendResultCode,
            CreatorDate = DateTime.Now,

        };
        return sms;
    }
}
