using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        IResult Add(CreditCard creditCard);
        IResult Delete(CreditCard creditCard);
        IResult Update(CreditCard creditCard);
        IDataResult<CreditCard> GetByCustomerId(int customerId);
        IDataResult<CreditCard> GetByNumber(string cardNumber);
    }
}
