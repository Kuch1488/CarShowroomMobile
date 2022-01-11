using CarShowroomMobile.Entitys;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CarShowroomMobile.Data
{
    public class RestService : IRestService
    {
        HttpClient client;
        JsonSerializerOptions serializerOptions;

        public List<Car> cars { get; private set; }

        public RestService()
        {
            client = new HttpClient();
            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<List<Car>> GetCars()
        {
            cars = new List<Car>();

            string Url = Constants.RestUrl;
            Url += "/api/Car/all";

            Uri uri = new Uri(string.Format(Url, string.Empty));

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if(response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    cars = JsonSerializer.Deserialize<List<Car>>(content, serializerOptions);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return cars;
        }
    }
}
