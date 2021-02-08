using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,DevRentACarContext>,ICarDal
    {

        public List<CarDetailDto> GetCarDetails()
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var result = from c in context.Cars
                    join co in context.Colors on c.ColorId equals co.Id
                    join b in context.Brands on c.BrandId equals b.Id

                    select new CarDetailDto
                    {
                        Id = c.Id,
                        Name = c.Name,
                        PlakaNo = c.PlakaNo,
                        BrandName = b.Name,
                        ColorName = co.Name,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
