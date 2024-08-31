using NotificationApplication.Commands;
using NotificationDomain.Models;

namespace NotificationApplication.Convertors;

public static class ToModels
{
    public static Sms ToModel(this SendSmsCommand command, string sendResultCode)
    {
        return new Sms(command.MobileNumber, command.Message, sendResultCode);
    }
}
