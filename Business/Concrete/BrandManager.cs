using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager :IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Add(brand);

                Console.WriteLine("Yeni model eklendi: " + brand.BrandName );

            }
            else
            {
                Console.WriteLine("Model ismi en az 2 karakter olmalıdır. Lütfen tekrar deneyiniz!!");
            }

        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka Silindi!");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandID == brandId);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka Güncellendi!");
            }
            else
            {
                Console.WriteLine("Lütfen marka ismini iki karakterden fazla giriniz!!");
            }
        }
    }
}
