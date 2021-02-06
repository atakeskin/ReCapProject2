using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstrct;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;

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
            if (car.Description.Length>2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba sisteme basariyla eklendi.");
            }
            else
            {
                Console.WriteLine("Araba tanımlaması 2 karekterden fazla olmalıdır.");
                Console.WriteLine("Araba günük fiyatı geçerli değer olmalıdır.");
            }

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba sistemde basariyla güncellendi.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba sistemden basariyla silindi.");
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id).ToList();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id).ToList();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice > min && c.DailyPrice < max).ToList();
        }

        public List<Car> GetByModelYear(int year)
        {
            return _carDal.GetAll(c => c.ModelYear.Year == year);
        }

        public IQueryable<CarDetail> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
