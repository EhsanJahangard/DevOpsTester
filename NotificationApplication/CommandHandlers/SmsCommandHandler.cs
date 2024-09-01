using InfrastructureService;
using MediatR;
using NotificationApplication.Commands;
using NotificationApplication.Contracts.Repositories;
using NotificationApplication.Convertors;

namespace NotificationApplication.CommandHandlers;

public class SmsCommandHandler : IRequestHandler<SendSmsCommand, ResponseMessage>
{
    private readonly IWriteOnlyRepository<NotificationDomain.Models.Sms> _writeOnlyRepository;

    public SmsCommandHandler(IWriteOnlyRepository<NotificationDomain.Models.Sms> writeOnlyRepository)
    {
        _writeOnlyRepository = writeOnlyRepository;
    }

    public async Task<ResponseMessage> Handle(SendSmsCommand request, CancellationToken cancellationToken)
    {
        try
        {
            request.Message += "\n لغو 11";
            string url = $"https://panel.asanak.com/webservice/v1rest/sendsms?username=aaaaaaa&password=000000000&Source=999999&Message={request.Message}&destination={request.MobileNumber}";

            HttpClient client = new HttpClient();
            HttpResponseMessage httpResponseMessage = await client.PostAsync(url, null);
            httpResponseMessage.EnsureSuccessStatusCode();
            var sendResultCode = await httpResponseMessage.Content.ReadAsStringAsync();
            sendResultCode = sendResultCode.Remove(0, 1);
            sendResultCode = sendResultCode.Remove(sendResultCode.Length - 1, 1);

            await _writeOnlyRepository.AddAsync(request.ToModel(sendResultCode));
            await _writeOnlyRepository.SaveChangesAsync();

            return new ResponseMessage();
        }
        catch (Exception ex)
        {
            return new ResponseMessage(ex.ToString());
        }
    }
}