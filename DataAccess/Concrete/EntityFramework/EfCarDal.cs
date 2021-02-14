using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,DevRentACarContext>,ICarDal
    {
        

        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarProperty(Expression<Func<Car, bool>> filter = null)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var result = (from c in filter is null ? context.Cars : context.Cars.Where(filter)
                    join co in context.Colors on c.ColorId equals co.Id
                    join b in context.Brands on c.BrandId equals b.Id

                    select new CarDetailDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        ModelYear = c.ModelYear,
                        PlakaNo = c.PlakaNo,
                        BrandName = b.Name,
                        ColorName = co.Name,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    }).ToList();
                return new SuccessDataResult<List<CarDetailDto>>(result);
            }
        }
    }
}
