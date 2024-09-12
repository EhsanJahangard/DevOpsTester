

namespace IdentityApplication.Utilities;

public class Sms
{
    public static async Task Send(string mobile, string message)
    {
        message += "\n لغو 11";
        string url = $"https://panel.asanak.com/webservice/v1rest/sendsms?username=avesta1399&password=0000000&Source=98210004040&Message={message}&destination={mobile}";

        HttpClient client = new HttpClient();
        client.Timeout = TimeSpan.FromSeconds(5);
        HttpResponseMessage httpResponseMessage = await client.PostAsync(url, null);
        httpResponseMessage.EnsureSuccessStatusCode();
        var sendResultCode = await httpResponseMessage.Content.ReadAsStringAsync();
        sendResultCode = sendResultCode.Remove(0, 1);
        sendResultCode = sendResultCode.Remove(sendResultCode.Length - 1, 1);

    }
}
