using System.Collections.Generic;
using System.Linq;
using Entities.ComplexTypes;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        IQueryable<CarDetail> GetCarDetails();
    }
}
