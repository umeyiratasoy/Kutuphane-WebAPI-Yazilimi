using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            if (car.Descriptionn.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else if (car.Descriptionn.Length > 2 && car.DailyPrice <= 0)
            {
                return new ErrorResult(Messages.CarIkıKarakterKucukNo + car.DailyPrice);
            }
            else if (car.Descriptionn.Length < 2 && car.DailyPrice > 0)
            {
                return new ErrorResult(Messages.CarIkıKarakterKucukYes + car.Descriptionn);
            }

            else
            {
                Console.WriteLine("Araba marka ismi minimum 2 karakter olmalı, günlük fiyat ise 0'dan büyük olmalıdır");
            }

            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarRemoved);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
            
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == colorId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult( Messages.CarUpdated);
        }
    }
}
