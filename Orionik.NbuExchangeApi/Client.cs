using System.Net.Http;
using System.Threading.Tasks;

namespace Orionik.NbuExchangeApi
{
    internal static class Client
    {
        public static async Task<string> SendGet(string baseUrl)
        {
            var client = new HttpClient();
            return await client.GetStringAsync(baseUrl);
        }
    }
}
