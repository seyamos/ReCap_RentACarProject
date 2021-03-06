﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;

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

        

        public IResult Add(Car car)   //voidleri IResult yaptık (add, delete, update void idi)
        {
            if (car.DailyPrice < 0)  
            {                
                return new ErrorResult(Messages.CarDailyPriceInvalid);  //ampul:generate constr. with fields
            }

            else if (car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.CarNameInvalid);

            }

            else
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }

        }


        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
            
        }

        public IResult Update(Car car)
        {           
                _carDal.Update(car);
                return new SuccessResult();
        }


        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 17)
            {
                return new ErrorDataResult<List<Car>>("Sistem Bakımda"); //çalışıyor mu denemek için bunu yazdım.Messages. diyerek yaparız bunuSistembakımda mesajı verebilriz
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }
        

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c =>c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }        
        

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }
    }
}


