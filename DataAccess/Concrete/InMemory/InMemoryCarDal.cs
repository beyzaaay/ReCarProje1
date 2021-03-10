using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()//ctor
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, ModelYear= "2020" ,Description="VOLKSWAGEN"},
                new Car{Id=2, BrandId=2, ColorId=3, DailyPrice=200, ModelYear= "2019" ,Description="BMW"},
                new Car{Id=3, BrandId=3, ColorId=2, DailyPrice=300, ModelYear= "2021" ,Description="AUDI"},
                new Car{Id=4, BrandId=4, ColorId=2, DailyPrice=150, ModelYear= "2018" ,Description="FIAT"},
                new Car{Id=5, BrandId=5, ColorId=3, DailyPrice=250, ModelYear= "2021" ,Description="DACİA"},
                new Car{Id=6, BrandId=6, ColorId=1, DailyPrice=400, ModelYear= "2019" ,Description="RANGE ROVER"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return null;
        }

        public List<Car> GetAll() //tümünü döndürür
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}

