using Business.Concrete;
using DateAccess.Concrete.EntityFramework;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }
            Car car1 = new Car();
            car1.BrandId = 2;
            car1.ColorId = 3;
            car1.DailyPrice = 102.0m;
            car1.ModelYear = "2005";
            car1.Description = "ASDF";
            carManager.Add(car1);
            
            carManager.Add(new Car { CarId = 1, BrandId = 1, ColorId = 23, DailyPrice = 344.5m, ModelYear = "2022", Description = "Fresh Comfort For Business Car" });
            
        }
    }
}