using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            //ColorGetAllTest();
            //BrandGetByIdTest();
            //ColorGetByIdTest();
            //BrandGetAllTest();
            //ColorCrudTest();
            //BrandCrudTest();
            //UserTest();
            //UserAdd();
            //RentalAdd();
            //RentalTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarId + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAdd()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 5, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(7) });
            rentalManager.Add(new Rental { CarId = 4, CustomerId = 1, RentDate = DateTime.Now });
            rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(2) });
            rentalManager.Add(new Rental { CarId = 3, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(3) });
            rentalManager.Add(new Rental { CarId = 1, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(4) });
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Id = 1, FirstName = "beyza", LastName = "ay", Email = "beyzaay@gmail.com", Password = "12345" });
            userManager.Add(new User { Id = 2, FirstName = "servet", LastName = "ay", Email = "servetay@gmail.com", Password = "12345" });
            userManager.Add(new User { Id = 3, FirstName = "Ceren", LastName = "ay", Email = "cerenay@gmail.com", Password = "12345" });

            

            
        }
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + " " + user.LastName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
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
