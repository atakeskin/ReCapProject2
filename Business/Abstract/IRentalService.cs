using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        #region Basic CRUD Signatures 
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);
        #endregion

        #region Private CRUD Signatures
        IDataResult<List<RentalDetailDto>> RentalDetails();
        #endregion
    }
}
