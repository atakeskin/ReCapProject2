using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        #region Basic CRUD Signatures 
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        #endregion

        #region Other CRUD Signatures
        IDataResult<List<CarDetailDto>> GetCarDetailsByCarProperty();
        IResult AddTransactionalTest(Car car);
        #endregion

        IDataResult<List<CarDetailDto>> GetCarByBrand(int brandId);
        IDataResult<List<CarDetailDto>> GetCarByColor(int colorId);
        IResult DeleteByCarId(CarDetailDto carDetailDto);
    }
}
