using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car() { Id = 6, BrandId = 3, ColorId = 2, ModelYear = "2001", DailyPrice = 1500, Description = "WV Caddy" };
            Car car2 = new Car() { Id = 3, BrandId = 3, ColorId = 1, ModelYear = "2001", DailyPrice = 1600, Description = "WV Tiguan" };



            carManager.Add(car1);
            carManager.Delete(car1);
            carManager.Update(car2);


            CarManager carManagerGetAll = new CarManager(new InMemoryCarDal());
            foreach (var car in carManagerGetAll.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);
            }


            Console.WriteLine("----------------GetById-----------------");
            var getById = carManager.GetById(2);
            foreach (var car in getById)
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.ModelYear);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Description);

            }

            //Console.WriteLine("Hello World!");
        }
    }
}
