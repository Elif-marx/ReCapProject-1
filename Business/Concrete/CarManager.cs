using Business.Abstract;using DataAccess.Abstract;using Entities.Concrete;using System;using System.Collections.Generic;using Entities.DTOs;

namespace Business.Concrete{

    public class CarManager : ICarService    {        ICarDal _carDal;        public CarManager(ICarDal carDal)        {            _carDal = carDal;        }        public void Add(Car car)        {            _carDal.Add(car);            Console.WriteLine("Car recorded.");        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Car deleted.");
        }

        public List<Car> GetAll()        {            return _carDal.GetAll();        }        public List<Car> GetCarsByBrandId(int id)        {            return _carDal.GetAll(p=>p.BrandId == id );        }        public List<Car> GetCarsByColorId(int id)        {            return _carDal.GetAll(c => c.ColorId == id);        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _carDal.GetProductDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Car Updated.");
        }
    }}