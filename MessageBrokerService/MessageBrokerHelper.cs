using RabbitMQ.Client;
using System.Text;

namespace EventBus.Messages;

public static class MessageBrokerHelper
{
    public static void Publish(string message, string queue)
    {
        IModel channel = CreateModel(queue);

        channel.BasicPublish("", queue, null, Encoding.UTF8.GetBytes(message));
    }

    public static IModel CreateModel(string queue)
    {
        ConnectionFactory factory = new ConnectionFactory() { HostName = MessageBrokerConstants.HostName, VirtualHost = MessageBrokerConstants.VirtualHost, Port = MessageBrokerConstants.Port, UserName = MessageBrokerConstants.UserName, Password = MessageBrokerConstants.Password };

        IConnection connection = factory.CreateConnection();

        IModel channel = connection.CreateModel();

        channel.QueueDeclare(queue, true, false, true, null);

        return channel;
    }
}
