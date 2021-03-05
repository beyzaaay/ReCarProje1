using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)//ctor
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length>=2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("eklendi");
            }
            else
            {
                Console.WriteLine("Lütfen Tekrar Deneyiniz");
            }
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            //iş koldarı yazılır
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByDailyPrice(int dailyprice)
        {
            return _carDal.GetAll(c => c.DailyPrice > 0);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
