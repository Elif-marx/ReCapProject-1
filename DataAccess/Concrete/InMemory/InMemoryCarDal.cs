using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { CarId= 1, BrandId=1, ColorId=1, DailyPrice=1000, ModelYear="1999", Description="Toyota Corolla"},
                new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 1100, ModelYear = "1999", Description = "Toyota Corona" },
                new Car { CarId = 3, BrandId = 2, ColorId = 1, DailyPrice = 1200, ModelYear = "2001", Description = "Hyudai Santa fe" },
                new Car { CarId = 4, BrandId = 2, ColorId = 2, DailyPrice = 1300, ModelYear = "2002", Description = "Hyundai ix35" },
                new Car { CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 1400, ModelYear = "2003", Description = "Suzuki Jimny" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int GetById)
        {
            return _cars.Where(c => c.CarId == GetById).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
        }
    }
}
