using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList()
                    : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Add(Car entity)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Car entity)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public IQueryable<CarDetail> GetCarDetails()
        {
            DevRentACarContext context = new DevRentACarContext();

                return from c in context.Cars
                    join co in context.Colors on c.ColorId equals co.Id
                    join b in context.Brands on c.BrandId equals b.Id

                    select new CarDetail
                    {
                        Id = c.Id,
                        ColorName = co.Name,
                        BrandName = b.Name,
                        DailyPrice = c.DailyPrice,
                        ModelYear = c.ModelYear,
                        Description = c.Description,
                    };

        }
    }
}
