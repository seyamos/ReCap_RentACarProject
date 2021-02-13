using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Color> colors = new List<Color>
//        {
//            new Color{ColorId=1, ColorName="Mavi"},
//            new Color{ColorId=2, ColorName="Kırmızı"},
//            new Color{ColorId=3, ColorName="Siyah"},
//        };  
        

//        List<Car> _cars;  //global dğşkn
//        public InMemoryCarDal()  //constructor : void yok , birşey döndürmüyor, class ın ismiyle tanımlı:bu contrc dır. ctor tab tab il e yapılır
//        {
//            //_cars = new List<Car> 
//            //{
//            //    new Car{CarId=1,Name="Toyota",BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=200,Descriptions=" 50000 km"},
//            //    new Car{CarId=2,Name="Honda",BrandId=1,ColorId=1,ModelYear=2015,DailyPrice=300,Descriptions=" 30000 km"},
//            //    new Car{CarId=3,Name="Bmw",BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=400,Descriptions=" 20000 km"},
//            //    new Car{CarId=4,Name="Mercedes A500",BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=500,Descriptions=" 10000 km"},
//            //    new Car{CarId=5,Name="Mercedes B600",BrandId=2,ColorId=3,ModelYear=2021,DailyPrice=600,Descriptions="  5000 km"},
//            //};


//            //Klasik Linq Test e göre dto daki color name i ekleyemedim
//            //var result = from c in _cars
//            //             where c.DailyPrice < 500
//            //             orderby c.ModelYear descending, c.Name ascending
//            //             select new CarDto { Id = c.Id, Name = c.Name, DailyPrice = c.DailyPrice,}; // buraya color name i ekleyemem ne yapacağim: veritabanımda color id var color name yok. Join op.kullanacağız
//            //foreach (var c in result)
//            //{
//            //    Console.WriteLine(c.Name);
//            //}

//            //CarDto daki color name i nasıl eklerim: ortak alan ColorId.
//            // _cars listesi ile colors listesini join etmeliyiz ve ortak alsn color id yi kullanmalıyız.

//            //var result = from ca in _cars
//            //             join co in colors
//            //             on ca.ColorId equals co.ColorId
//            //             where ca.DailyPrice<500
//            //             orderby ca.DailyPrice descending
//            //             select new CarDto { Id = ca.Id, Name = ca.Name, DailyPrice = ca.DailyPrice, ColorName = co.ColorName };
//            //foreach (var carDto in result)
//            //{
//            //    Console.WriteLine("{0}-{1}-{2}", carDto.Name , carDto.ColorName, carDto.DailyPrice);
//            //}


//            //***LINQ

//            //var result = from c in _cars
//            //             where c.DailyPrice < 500
//            //             orderby c.ModelYear descending, c.Name ascending
//            //             select c;
//            //foreach (var c in result)
//            //{
//            //    Console.WriteLine(c.Name);
//            //}



//            //***Single Line Query***

//            //Any : Listemde varsa true, yoksa false döner.
//            //var result = _cars.Any(c => c.Name == "Hyundai");
//            //Console.WriteLine(result);

//            //Find : Id=1 olan ürünün hh.bir detayını görmek istersek.
//            //var result = _cars.Find(c => c.Id == 1);
//            //Console.WriteLine(result.Name);
//            //Console.WriteLine(result.DailyPrice);

//            //FindAll:
//            //var result = _cars.FindAll(c => c.Name.Contains("Mercedes"));

//            //foreach (var car in result)
//            //{
//            //    Console.WriteLine(car.Name);
//            //}

//            //Where:
//            //var result = _cars.Where(c => c.Name == "Mercedes" && c.DailyPrice < 600);            
//            //foreach (var car in result)
//            //{
//            //    Console.WriteLine(car.Id);
//            //}

//            //var result = _cars.Where(c => c.Name.Contains("Mercedes") && c.DailyPrice < 600);            
//            //foreach (var car in result)
//            //{
//            //    Console.WriteLine(car.Name);
//            //}


//            //Acs Desc :
//            //var result = _cars.Where(c => c.Name.Contains("Mer")).OrderByDescending(c => c.DailyPrice).ThenBy(c => c.Name);
//            //foreach (var car in result)
//            //{
//            //    Console.WriteLine(car.Name);
//            //}




//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)  //LINQ : Language Integrated Query
//        {
//            Car carToDelete = _cars.Where(c=> c.CarId == car.CarId).SingleOrDefault();    //(system linq) => bu işarete lambda denir

//            _cars.Remove(carToDelete);
            
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> Sorted()
//        {
//            return _cars.OrderByDescending(c => c.DailyPrice).ToList();
            
//        }
        


//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.CarId = car.CarId;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Descriptions = car.Descriptions;
//        }

//        //Car ICarDal.GetById(int Id)
//        //{
//            //return _cars.Where(c => c.Id == Id).SingleOrDefault();
//        //}

        

//    }

//    //class CarDto  //Dto kullanımı için bu sınıfı oluşturdum. En üstteki kodlara bak.diğer class immemorydal zaten. orada olmayan bir alan ekledim. color name 
//    //{
//    //    public int Id { get; set; }
//    //    public string Name { get; set; }
//    //    public decimal DailyPrice { get; set; }
//    //    public string ColorName { get; set; }

//    //}
//}
