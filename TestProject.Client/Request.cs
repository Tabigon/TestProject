using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TestProject.Client
{
    public static class Request<T>
    {
        private const string Url = "http://localhost:53738/";

        public static bool PostRequest(T model, string path)
        {
            var client = new HttpClient { BaseAddress = new Uri(Url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.PostAsJsonAsync(Url + path, model);

            return response.Result.IsSuccessStatusCode;
        }
    }
}
