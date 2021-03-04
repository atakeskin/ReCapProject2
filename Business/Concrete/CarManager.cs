using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Aspects.Caching;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        [CacheAspect]
        //[PerformanceAspect(5)]
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id),Messages.CarListed);
        }
        [SecuredOperation("car.add")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            //Buraya iş motoru yazılacak.

            IResult result = CheckIfNameAlreadyExists(car.Name);
            if (result!=null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        private IResult CheckIfNameAlreadyExists(string name)
        {
            if (_carDal.Get(c => c.Name == name) != null)
            {
                { 
                    return new ErrorResult(Messages.CarNameAlreadyExists);
                }
            }

            return null;
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            IResult result = CheckIfNameAlreadyExists(car.Name);
            if (result != null)
            {
                return result;
            }
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }


        public IDataResult<List<CarDetailDto>> GetCarDetailsByCarProperty(Expression<Func<Car, bool>> filter=null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsByCarProperty(filter).Data, Messages.CarsListed);
        }

        //[TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {

            Add(car);
            if (car.DailyPrice < 250)
            {
                throw new Exception("");
            }

            Add(car);

            return null;
        }
    }
}
