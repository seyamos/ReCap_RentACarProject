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
        List<Car> _cars;  //global dğşkn
        public InMemoryCarDal()  //constructor : void yok , birşey döndürmüyor, class ın ismiyle tanımlı:bu contrc dır. ctor tab tab il e yapılır
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=200,Description=" 50000 km"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2010,DailyPrice=300,Description=" 30000 km"},
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=400,Description=" 20000 km"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=500,Description=" 10000 km"},
                new Car{Id=5,BrandId=2,ColorId=3,ModelYear=2021,DailyPrice=600,Description="  5000 km"},
            };
                
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)  //LINQ : Language Integrated Query
        {
            Car carToDelete = _cars.Where(c=> c.Id == car.Id).SingleOrDefault();    //(system linq) => bu işarete lambda denir

            _cars.Remove(carToDelete);
            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
        
        
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        Car ICarDal.GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).SingleOrDefault();
        }
    }
}
