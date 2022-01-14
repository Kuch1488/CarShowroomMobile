using CarShowroomMobile.Entitys;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarShowroomMobile.Data
{
    public interface IRestService
    {
        Task<List<Car>> GetCars();
        Task DeleteCarAsync(string vinNumber);

        Task SaveCarAsync(Car car, bool isNewItem);
    }
}
