using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NotificationDomain.Models;

public class Sms
{
    public Sms(string mobileNumber, string message, string sendResultCode)
    {
    
        MobileNumber = mobileNumber;
        Message = message;
        SendResultCode = sendResultCode;
        CreatorDate = DateTime.Now;
    }
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }   
    public string MobileNumber { get; set; }
    public string Message { get; set; }
    public string SendResultCode { get; set; }
    public DateTime CreatorDate { get; set; }

    private Sms() { }
}
