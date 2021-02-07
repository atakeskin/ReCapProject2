using System.Collections.Generic;
using System.Linq;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstrct
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByModelYear(int year);

        List<CarDetailDto> GetCarDetails();
    }
}
