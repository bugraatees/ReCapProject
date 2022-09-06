using DateAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {     
            new Car {CarId=1, BrandId=1, ColorId=23, DailyPrice=344.5m, ModelYear=2022, Description = "Fresh Comfort For Business Car"},
            new Car {CarId=2, BrandId=1, ColorId=4, DailyPrice=250.5m, ModelYear=2021, Description = "Similar For Economic Class Car"},
            new Car {CarId=3, BrandId=1, ColorId=3, DailyPrice=229.5m, ModelYear=2019, Description = "Comfort For Middle Class Car"},
            new Car {CarId=4, BrandId=2, ColorId=33, DailyPrice=185.8m, ModelYear=2018, Description = "Fresh Comfort For Business Car"},
            new Car {CarId=5, BrandId=2, ColorId=45, DailyPrice=50.6m, ModelYear=1985, Description = "Old UnComfortable Foor Poor Class Car"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsOfDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carsOfDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

       

        public List<Car> GetById(int brandid)
        {
            return _cars.Where(c => c.BrandId == brandid).ToList();
        }

        public void Update(Car car)
        {
            Car carsOfDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carsOfDelete.BrandId = car.BrandId;
            carsOfDelete.ColorId = car.ColorId;
            carsOfDelete.DailyPrice = car.DailyPrice;
            carsOfDelete.Description = car.Description;
        }
    }
}
