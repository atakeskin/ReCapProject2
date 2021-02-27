using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        #region Basic CRUD Signatures 

        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int id);
        IResult Add(IFormFile file, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);

        #endregion

        #region Other CRUD Signatures

        IDataResult<List<CarImage>> GetImagesByCarId(int id);

        #endregion
    }
}
