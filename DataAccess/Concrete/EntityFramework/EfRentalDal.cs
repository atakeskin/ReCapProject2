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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DevRentACarContext>, IRentalDal
    {
        public IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (DevRentACarContext context = new DevRentACarContext())
            {
                var result = (from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                    join c in context.Cars on r.CarId equals c.Id
                    join cu in context.Customers on r.CustomerId equals cu.Id
                    join u in context.Users on cu.UserId equals u.Id
                              select new RentalDetailDto
                    {
                        Id = r.Id,
                        CarName = c.Name,
                        CarPlakaNo = c.PlakaNo,
                        UserFirstName = u.FirstName,
                        UserLastName = u.LastName,
                        CompanyName = cu.CompanyName,
                        Email = u.Email,
                        RentDate = r.RentDate,
                        ReturnDate = r.ReturnDate
                    }).ToList();
                return new SuccessDataResult<List<RentalDetailDto>>(result);
            }
        }
    }
}
