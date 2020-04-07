using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RoboSter.Utilities.Container;
using RoboSter.Utilities.Helpers;
using RoboSter.Utilities.Json;

namespace RoboSter.Server.Service.WebService
{
    [PreventAutoRegistration]
    public class WebApiClient : IWebApiClient
    {
        private readonly HttpClient client;

        public WebApiClient(HttpClient client)
        {
            this.client = client;
        }
        
        public async Task<TRes> ApiGet<TRes>(string uri) where TRes : class
        {
            var response = await client.GetAsync(uri);
            return (await Process(response))?.Deserialize<TRes>();
        }

        public async Task<TRes> ApiPost<TRes>(string uri, object request) where TRes : class
        {
            var content = new StringContent(request.ToJson(), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(uri, content);
            return (await Process(response))?.Deserialize<TRes>();
        }

        private static async Task<string> Process(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return await response.Content.ReadAsStringAsync();

            return await Task.FromResult<string>(null);
        }
    }
}