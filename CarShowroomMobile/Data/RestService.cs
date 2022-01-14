using CarShowroomMobile.Entitys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;

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

            string url = Constants.RestUrl + "/api/Car/all";

            Uri uri = new Uri(string.Format(url, string.Empty));

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    cars = JsonConvert.DeserializeObject<List<Car>>(content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return cars;
        }

        public async Task DeleteCarAsync(string vin_number)
        {
            string url = Constants.RestUrl + $"/api/Car/{vin_number}";
            Uri uri = new Uri(string.Format(url, string.Empty));

            try
            {
                HttpResponseMessage response = await client.DeleteAsync(uri);

                if(response.IsSuccessStatusCode) Debug.WriteLine(@"\tCar successfully deleted.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task SaveCarAsync(Car car, bool isNewItem = false)
        {
            string url = Constants.RestUrl + $"/api/Car/create";
            Uri uri = new Uri(string.Format(url, string.Empty));

            try
            {
                string json = System.Text.Json.JsonSerializer.Serialize<Car>(car, serializerOptions);
                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if(isNewItem)
                {
                    response = await client.PostAsync(uri, stringContent);
                }
                else
                {
                    response = await client.PutAsync(uri, stringContent);
                }

                if(response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"\tTodoItem successfully saved.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
