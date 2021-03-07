using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("Araç Adı : " + car.CarName + " Marka No: "+ car.BrandId);
            }
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine("Araç Adı : " + car.CarName + " Renk No: " + car.ColorId);
            }
            foreach (var car in carManager.GetCarsByDailyPrice(200,400))
            {
                Console.WriteLine("Araç Adı : " + car.CarName + " Günlük Fiyat:  "+ car.DailyPrice);
            }
        }
    }
}
