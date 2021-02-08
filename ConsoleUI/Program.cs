using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            
            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(car.Description);
            }

            //Toyota marka araçları getir. 1=Toyota
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }

            // Mavi renkli arabaları getir. 3=Mavi
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            }

            foreach (var car in carManager.GetProductDetails())
            {
                Console.WriteLine(car.Id + " - BrandName: " + car.BrandName + " - ColorName: " + car.ColorName + " - DailyPrice:" + car.DailyPrice + " - ModelYear: " + car.ModelYear + " - Description: " + car.Description);
            }


            Console.WriteLine("Araç Kayıt:");
            Console.WriteLine("Araç ID");
            int id = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Toyota = 1, VW = 2, Hyundai = 3");
            Console.WriteLine("Brand ID: Giriniz.");
            int BrandId = Int16.Parse(Console.ReadLine());
            Console.WriteLine("White = 1, Red = 2, Blue = 3");
            Console.WriteLine("Color ID: Enter.");
            int ColorId = Int16.Parse(Console.ReadLine());
            
            Console.WriteLine("Model Year: Enter.(like: 2000)");
            string ModelYear = Console.ReadLine();

            Console.WriteLine("Daily Price: Enter.");
            decimal DailyPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Description: Enter.");
            string Description = Console.ReadLine();
            if (Description.Length<=2)
            {
                Console.WriteLine("You entered less than 2 characters.");
                Console.WriteLine("Re-enter:");
                Description = Console.ReadLine();
            }
           
                carManager.Add(new Car { Id=id,BrandId=BrandId, ColorId=ColorId, ModelYear=ModelYear, DailyPrice=DailyPrice, Description=Description });
            }
    }
}
