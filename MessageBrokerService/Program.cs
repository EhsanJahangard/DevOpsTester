using InfrastructureService;
using MessageBrokerService;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;


IModel channel = MessageBrokerHelper.CreateModel("sms");
EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
consumer.Received += Consumer_Received;
channel.BasicConsume("sms", true, consumer);

Console.ReadLine();

static void Consumer_Received(object? sender, BasicDeliverEventArgs e)
{
    string message = Encoding.UTF8.GetString(e.Body.ToArray());

    Sms sms = JsonConvert.DeserializeObject<Sms>(message);

    string url = "https://localhost:7244/api/sms/send";
    object data = new { MobileNumber = sms.MobileNumber, Message = sms.Message };
    HttpClientHelper.PostAsyn(url, data).Wait();
}
