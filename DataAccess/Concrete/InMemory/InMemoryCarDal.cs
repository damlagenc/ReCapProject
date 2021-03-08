using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            
        }
    }
}
