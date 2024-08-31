namespace NotificationDomain.Models;

public class Sms
{
    public Sms(string mobileNumber, string message, string sendResultCode)
    {
        Id = Guid.NewGuid();
        MobileNumber = mobileNumber;
        Message = message;
        SendResultCode = sendResultCode;
        CreatorDate = DateTime.Now;
    }

    public Guid Id { get; set; }
    public string MobileNumber { get; set; }
    public string Message { get; set; }
    public string SendResultCode { get; set; }
    public DateTime CreatorDate { get; set; }

    private Sms() { }
}
