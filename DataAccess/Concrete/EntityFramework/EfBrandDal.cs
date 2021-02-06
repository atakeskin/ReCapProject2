using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public void Add(Brand entity)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Brand entity)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
                context.SaveChanges();
            }
        }
    }
}
