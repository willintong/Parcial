using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Xamarin.Helpers
{
    public static class ApiHelper
    {
        public static T Get<T>(string url)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://apisunac.azurewebsites.net");

            var request = client.GetAsync(url).Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<T>(responseJson);

                return response;
            }

            return default(T);
        }
    }
}
