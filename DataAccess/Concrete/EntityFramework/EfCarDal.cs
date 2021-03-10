using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDataBaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDataBaseContext context = new MyDataBaseContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.BrandId
                             join co in context.Colors
                             on car.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description

                             };
                return result.ToList();

            }
        }
    }
}
