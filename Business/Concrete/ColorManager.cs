using System;
using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal ColorDal)
        {
            _colorDal = ColorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(co => co.Id == id);
        }

        public void Add(Color Color)
        {
            _colorDal.Add(Color);
            Console.WriteLine("Renk sisteme basariyla eklendi.");
        }

        public void Update(Color Color)
        {
            _colorDal.Update(Color);
            Console.WriteLine("Renk sistemde basariyla güncellendi.");
        }

        public void Delete(Color Color)
        {
            _colorDal.Delete(Color);
            Console.WriteLine("Renk sistemden basariyla silindi.");
        }

    }
}
