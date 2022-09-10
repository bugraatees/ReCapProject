using Business.Concrete;
using DateAccess.Concrete.EntityFramework;
using DateAccess.Concrete.InMemory;
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
        }
    }
}