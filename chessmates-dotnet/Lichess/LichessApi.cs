namespace chessmates_dotnet.Lichess
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public interface IApiService<T>
    {
        Task<T[]> Get(string path);
    }

    public class LichessApiService<T> : IApiService<T>
    {
        public async Task<T[]> Get(string path)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://en.lichess.org/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync($"api/{path}");

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var paginatedResponse = JObject.Parse(jsonString);

                    var results = paginatedResponse["paginator"] != null ?
                        paginatedResponse["paginator"]["currentPageResults"].Children().ToList() :
                        paginatedResponse["currentPageResults"].Children().ToList();

                    var items = results.Select(p => p.ToObject<T>()).ToArray();

                    return items;
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }
    }
}