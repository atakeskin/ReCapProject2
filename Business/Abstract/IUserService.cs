using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IUserService
    {
        #region Basic CRUD Signatures 
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int id);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        //void Add(User user);
        //User GetByMail(string email);
        IDataResult<User> GetByMail(string email);
        #endregion

        IResult EditProfile(UserForUpdateDto user);
    }
}
