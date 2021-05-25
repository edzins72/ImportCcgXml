using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImportCcgXml
{
    public class RequestData
    {
        private static readonly HttpClient httpClient;

        static RequestData()
        {
            httpClient = new HttpClient();
        }

        // This method uses the shared instance of HttpClient for every call to GetProductAsync.
        public static async Task<Response> GetProductAsync(string id)
        {
            var result = await httpClient.GetStringAsync(string.Format("https://starfish.news/export/{0}/ccg", id));
            return new Response { XML = result };
        }
    }
}
