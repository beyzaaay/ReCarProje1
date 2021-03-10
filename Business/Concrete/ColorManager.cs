using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            //iş koldarı yazılır
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
