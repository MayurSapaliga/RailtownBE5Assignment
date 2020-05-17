using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Security;
using System.Threading.Tasks;

namespace RailTown.Infrastructure
{
    public class ApplicationContext: IApplicationContext
    {
        private readonly string url;
        private readonly IConfiguration _config;
        private readonly string code;
        public ApplicationContext(IConfiguration config)
        {
            //// http://localhost:7071/api/GetFarthestUsers
            _config = config;
            url = _config.GetSection("AppSettings").GetSection("AzureFunctionURL").Value;
            code = _config.GetSection("AppSettings").GetSection("Code").Value;
        }

        public Task<string> MakeExternalCall(string functionName)
        {
            var client = new HttpClient();
            var uri = url + functionName + "?code=" + code;
            var response = client.GetAsync(uri).GetAwaiter().GetResult();

            return response.Content.ReadAsStringAsync();
        }
    }
}
