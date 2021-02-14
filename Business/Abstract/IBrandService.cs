using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        #region Basic CRUD Signatures
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(Brand brand);
        #endregion
    }
}
