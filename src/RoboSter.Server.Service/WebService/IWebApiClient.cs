using System.Threading.Tasks;

namespace RoboSter.Server.Service.WebService
{
    public interface IWebApiClient
    {
        Task<TRes> ApiGet<TRes>(string uri) where TRes : class;
        Task<TRes> ApiPost<TRes>(string uri, object request) where TRes : class;
    }
}