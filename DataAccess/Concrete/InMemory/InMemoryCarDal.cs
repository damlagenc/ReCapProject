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
            _cars = new List<Car>
            {
                new Car{BrandID=1, ColorID=2 , DailyPrice=150, ID = 12345, ModelYear=1999,
                    Description = "Hasarsız, beyaz renk, 1999 model Range Rover " },
                new Car{BrandID=2, ColorID= 3, DailyPrice= 200, ID = 54321, ModelYear =2018,
                    Description = "2018 model siyah renk Mercedes"},
                new Car{BrandID=3, ColorID= 4, DailyPrice= 300, ID = 63254, ModelYear =2021,
                    Description = "2021 model kırmızı renk Tesla"},
                new Car{BrandID=4, ColorID=5, DailyPrice= 100, ID = 23564, ModelYear =2001,
                    Description = "2001 model mavi Volvo"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.ID == car.ID);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int ID)
        {
            return _cars.Where(c => c.ID == ID).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.ID == car.ID);

            carToUpdate.ID = car.ID;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

            
        }
    }
}
