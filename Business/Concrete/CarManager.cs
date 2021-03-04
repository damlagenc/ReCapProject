using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if ( car.DailyPrice > 0 && car.Description.Length >= 2)
            {
                _carDal.Add(car);
                
                Console.WriteLine("Yeni araç eklendi: " + car.Description + " günlük " + car.DailyPrice + " lira");
                
            }
            else
            {
                Console.WriteLine("Açıklama en az 2 karakter olmalıdır ve günlük ücret 0' dan büyük olmalıdır. Lütfen tekrar deneyiniz!!");
            }
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min)
        {
            return _carDal.GetAll(c => c.DailyPrice >=min);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorID == id);
        }


        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.Description.Length >= 2);
        }
    }
}
