using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NotificationDomain.Models;

public class Sms
{
    
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    [BsonElement("MobileNumber")]
    public string MobileNumber { get; set; }
    [BsonElement("Message")]
    public string Message { get; set; }
    [BsonElement("SendResultCode")]
    public string SendResultCode { get; set; }
    [BsonElement("CreatorDate")]
    public DateTime CreatorDate { get; set; }

  
}
