using CarShowroomMobile.Entitys;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarShowroomMobile.Data
{
    public class RestService : IRestService
    {
        HttpClient client;

        public List<Car> cars { get; private set; }

        public RestService() => client = new HttpClient();

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
    }
}
