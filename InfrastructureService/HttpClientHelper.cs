using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace InfrastructureService
{
    public class HttpClientHelper
    {
        public static async Task<ResponseMessage> PostAsyn(string url,object data)
        {
            HttpClient client = new HttpClient();
            byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            ByteArrayContent content = new ByteArrayContent(buffer, 0, buffer.Length);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponseMessage = await client.PostAsync(url, content);
            httpResponseMessage.EnsureSuccessStatusCode();
            var result = await httpResponseMessage.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ResponseMessage>(result);
        }
    }
}
