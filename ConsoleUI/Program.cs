using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
            //ColorGetAllTest();
            //BrandGetByIdTest();
            //ColorGetByIdTest();
            //BrandGetAllTest();
            //ColorCrudTest();
            //BrandCrudTest();
        }

        private static void BrandCrudTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Mercedes" });
            brandManager.Update(new Brand { BrandId = 3, BrandName = "kartal" });
        }

        private static void ColorCrudTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "mavi" });
            colorManager.Delete(new Color { ColorName = "kırmızı" });
            colorManager.Update(new Color { ColorId = 1, ColorName = "turuncu" });
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + brand.BrandName);
            }
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(3).ColorName);
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(2).BrandName);
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine("Marka " + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                 foreach (var car in result.Data)
                 {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName+ "/"+ car.DailyPrice+ "/"+ car.Description);
                 }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
            //foreach (var car in carManager.GetCarsByBrandId(2))
            //{
            //    Console.WriteLine("Araç Adı : " + car.CarName + " Marka No: " + car.BrandId);
            //}
            //foreach (var car in carManager.GetCarsByColorId(3))
            //{
            //    Console.WriteLine("Araç Adı : " + car.CarName + " Renk No: " + car.ColorId);
            //}
            //foreach (var car in carManager.GetCarsByDailyPrice(200, 400))
            //{
            //    Console.WriteLine("Araç Adı : " + car.CarName + " Günlük Fiyat:  " + car.DailyPrice);
            //}
        }
    }
}
