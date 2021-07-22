using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Get_Temperature
{
    class Logic
    {
        private static string weatherUrl = "https://goweather.herokuapp.com/weather";
        public static async Task SendTempRequest(Data.Cities city)
        {
            string temperature;
            try
            {
                string url = $"{weatherUrl}/{city}";
                HttpClient _client = new HttpClient();
                HttpResponseMessage response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseContent);
                temperature = json.SelectToken("$.temperature").ToString();
            }
            catch
            {
                temperature = "not found";
            }
            Data.Temperatures[city] = temperature;
        }
    }
}
