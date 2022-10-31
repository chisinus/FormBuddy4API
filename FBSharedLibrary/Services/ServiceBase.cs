using FBSharedLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FBSharedLibrary.Services
{
    public class ServiceBase : IServiceBase
    {
        public async Task<string> CallService(string baseUrl, string api, string parameters)
        {
            string result = "";
            using (var client = new HttpClient())
            {
                //set up client
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(parameters, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(api, content);
                result = await response.Content.ReadAsStringAsync();
            }
            //HttpClient client = new HttpClient();

            ////client.BaseAddress = new Uri(url + api);
            //client.DefaultRequestHeaders.Accept.Add(
            //new MediaTypeWithQualityHeaderValue("application/json"));

            //T? result = default;

            //// Blocking call! Program will wait here until a response is received or a timeout occurs.
            //HttpResponseMessage response = await client.GetAsync(url + api);
            //if (response.IsSuccessStatusCode)
            //{
            //    string value = await response.Content.ReadAsStringAsync();
            //    if (!string.IsNullOrEmpty(value)) result = JsonConvert.DeserializeObject<T>(value);
            //}

            return result;
        }
    }
}
