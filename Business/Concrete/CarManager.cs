using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
            if (car.Descriptionn.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else if (car.Descriptionn.Length > 2 && car.DailyPrice <= 0)
            {
                Console.WriteLine("Araba Fiyatı Sıfırdan Küçük Olamaz: " + car.DailyPrice);
            }
            else if (car.Descriptionn.Length < 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Araba İsmi En Az İki Kelime Olmalıdır: " + car.Descriptionn);
            }

            else
            {
                Console.WriteLine("Araba marka ismi minimum 2 karakter olmalı, günlük fiyat ise 0'dan büyük olmalıdır");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.Id == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.Id == colorId);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
