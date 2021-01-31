using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //GetById, GetAll, Add, Update, Delete
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int GetById);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
