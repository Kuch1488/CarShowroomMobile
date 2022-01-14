using CarShowroomMobile.Entitys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroomMobile.Data
{
    public class ItemManager
    {
        private readonly IRestService _restService;

        public ItemManager(IRestService restService) => _restService = restService;

        public async Task<List<Car>> GetCars()
        {
            return await _restService.GetCars();
        }

        public Task SaveTaskAsync(Car car, bool isNewItem = false)
        {
            return _restService.SaveCarAsync(car, isNewItem);
        }

        public Task DeleteTaskAsync(Car car)
        {
            return _restService.DeleteCarAsync(car.VinNumber);
        }
    }
}
