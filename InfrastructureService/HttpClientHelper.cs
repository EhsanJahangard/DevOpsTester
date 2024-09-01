using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

namespace InfrastructureService;

public class HttpClientHelper
{
    public static async Task<ResponseMessage> PostAsync(string url, object data)
    {
        ResponseMessage response = new ResponseMessage();
        try
        {

            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(5);
            byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            ByteArrayContent content = new ByteArrayContent(buffer, 0, buffer.Length);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponseMessage = await client.PostAsync(url, content);
            httpResponseMessage.EnsureSuccessStatusCode();
            var result = await httpResponseMessage.Content.ReadAsStringAsync();

            response = JsonConvert.DeserializeObject<ResponseMessage>(result);
            return response;
        }
        catch (Exception ex)
        {
            return response;
        }

    }
}
