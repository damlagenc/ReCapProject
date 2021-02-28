using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID : "+car.ID);
                Console.WriteLine("Araç Açıklama : "+car.Description);
                Console.WriteLine("Günlük Ücret : "+car.DailyPrice);
                Console.WriteLine("Araç Renk : "+car.ColorID);
                Console.WriteLine("Model ID : "+car.BrandID);
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}
