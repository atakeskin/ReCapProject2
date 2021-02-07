using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.Id == id);
        }

        public void Add(Brand Brand)
        {
            _brandDal.Add(Brand);
            Console.WriteLine("Marka sisteme basariyla eklendi.");
        }

        public void Update(Brand Brand)
        {
            _brandDal.Update(Brand);
            Console.WriteLine("Marka sistemde basariyla güncellendi.");
        }

        public void Delete(Brand Brand)
        {
            _brandDal.Delete(Brand);
            Console.WriteLine("Marka sistemden basariyla silindi.");
        }

    }
}
