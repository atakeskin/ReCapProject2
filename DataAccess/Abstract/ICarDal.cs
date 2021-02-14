using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarProperty(Expression<Func<Car, bool>> filter = null);
    }
}
