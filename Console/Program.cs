using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                BrandID = 42,
                ColorID = 24,
                DailyPrice = 160,
                ModelYear = 2021,
                Description = "Yeni Araç",
                ID = 42
            });
           */
           
            
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand
            {
                BrandName = "Mustang",
                BrandID = 43

            }) ;


            
            /*foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID : "+car.ID);
                Console.WriteLine("Araç Açıklama : "+car.Description);
                Console.WriteLine("Günlük Ücret : "+car.DailyPrice);
                Console.WriteLine("Araç Renk : "+car.ColorID);
                Console.WriteLine("Model ID : "+car.BrandID);
                Console.WriteLine("------------------------------------------");
            }
            */
            /*
            foreach (var car in carManager.GetByDailyPrice(350))
            {
                Console.WriteLine("Araç ID : " + car.ID);
                Console.WriteLine("Araç Açıklama : " + car.Description);
                Console.WriteLine("Günlük Ücret : " + car.DailyPrice);
                Console.WriteLine("Araç Renk : " + car.ColorID);
                Console.WriteLine("Model ID : " + car.BrandID);
                Console.WriteLine("------------------------------------------");
            }
            Console.WriteLine("--------------------------------------------------------------------");
            
            foreach (var car in carManager.GetCarsByBrandId(17))
            {
                Console.WriteLine("Araç ID : " + car.ID);
                Console.WriteLine("Araç Açıklama : " + car.Description);
                Console.WriteLine("Günlük Ücret : " + car.DailyPrice);
                Console.WriteLine("Araç Renk : " + car.ColorID);
                Console.WriteLine("Model ID : " + car.BrandID);
                Console.WriteLine("------------------------------------------");
            }

            Console.WriteLine("--------------------------------------------------------------------");
            
            foreach (var car in carManager.GetCarsByColorId(6))
            {
                Console.WriteLine("Araç ID : " + car.ID);
                Console.WriteLine("Araç Açıklama : " + car.Description);
                Console.WriteLine("Günlük Ücret : " + car.DailyPrice);
                Console.WriteLine("Araç Renk : " + car.ColorID);
                Console.WriteLine("Model ID : " + car.BrandID);
                Console.WriteLine("------------------------------------------");
            }
            */



        }
    }
}
