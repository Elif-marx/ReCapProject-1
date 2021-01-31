using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id=1, BrandId=1, ColorId=1, DailyPrice=1000, ModelYear="1999", Description="Toyota Corolla"},
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 1100, ModelYear = "1999", Description = "Toyota Corona" },
                new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 1200, ModelYear = "2001", Description = "Hyudai Santa fe" },
                new Car { Id = 4, BrandId = 2, ColorId = 2, DailyPrice = 1300, ModelYear = "2002", Description = "Hyundai ix35" },
                new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 1400, ModelYear = "2003", Description = "Suzuki Jimny" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int GetById)
        {
            return _cars.Where(c => c.Id == GetById).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
