using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    BrandId = 1,
                    ColorId = 1,
                    ModelYear = new DateTime(01,01,2020),
                    DailyPrice = 250,
                    Description = "Benzinli 1.2 HB"
                },
                new Car
                {
                    Id = 2,
                    BrandId = 1,
                    ColorId = 1,
                    ModelYear = new DateTime(01,01,2021),
                    DailyPrice = 270,
                    Description = "Elektrikli"
                }
            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            //return filter == null
            //    ? _cars
            //    : _cars.Where(filter).ToList();
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            //return _cars.SingleOrDefault(filter);
            return _cars[0];
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Update(Car entity)
        {
            Car car = GetToBeProcessedCar(entity);
            car.Id = entity.Id;
            car.BrandId = entity.BrandId;
            car.ColorId = entity.ColorId;
            car.DailyPrice = entity.DailyPrice;
            car.Description = entity.Description;
            car.ModelYear = entity.ModelYear;
        }

        public void Delete(Car entity)
        {
            _cars.Remove(GetToBeProcessedCar(entity));
        }

        public IQueryable<CarDetail> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        private Car GetToBeProcessedCar(Car car)
        {
            return _cars.SingleOrDefault(c => c.Id == car.Id);
        }
    }
}
