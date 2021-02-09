using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c=>c.Id == id);
        }

        public void Add(Car car)
        {
            if (car.Name.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("New Car is added.");
            }
            else
            {
                Console.WriteLine("please give a car with daily price greater than 0 and name lenght longer than 2");
            }

        }

        public void Update(Car car)
        {

            if (car.Name.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Car is Updated.");
            }
            else
            {
                Console.WriteLine("please give a car with daily price greater than 0 and name lenght longer than 2");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car is deleted");
        }

        public List<CarDetailDto> GetCarsByBrandId(int id)
        {
            return _carDal.GetCarDetails(c => c.BrandId == id).ToList();
        }

        public List<CarDetailDto> GetCarsByColorId(int id)
        {
            return _carDal.GetCarDetails(c => c.ColorId == id).ToList();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice > min && c.DailyPrice < max).ToList();
        }

        public List<Car> GetByModelYear(int year)
        {
            return _carDal.GetAll(c => c.ModelYear.Year == year);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
