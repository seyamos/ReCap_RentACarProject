using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());



            Console.WriteLine("Brand Id'si 1 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n\nCar Id'si 2 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            Car carById = carManager.GetById(2);
            Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Descriptions}");


            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 165 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(100, 165))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            Console.WriteLine("\n");

            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = -500, ModelYear = "2021", Descriptions = "Otomatik Dizel" });
            brandManager.Add(new Brand { BrandName = "H" });

            Console.WriteLine("\n");


            carManager.Delete(new Car { CarId = 6 });
            carManager.Delete(new Car { CarId = 5 });
            
            Console.WriteLine("\n\nTüm Araçların Listesi: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions\tBrand Id");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}\t\t{car.BrandId}");

            }

        }

        
    }
}



//Console.WriteLine("***Tüm Araçların Listesi***");

//foreach (var car in carManager.GetAll())
//{                
//    Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: "  + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);
//}

//Console.WriteLine("--------------------");
//Console.WriteLine("***Yeni Bir Aracın Eklenmesi ve Araçların Yeniden Listelenmesi***");
//Car car6 = new Car() { Id = 6, BrandId = 3, ColorId = 4, ModelYear = 2022, DailyPrice = 900, Description = "     0 km" };            
//carManager.Add(car6);            
//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);
//}

//Console.WriteLine("--------------------");
//Console.WriteLine("***Id No'su 1 Olan Aracın Güncellenmesi ve Araçların Yeniden Listelenmesi***");
////Güncellenecek Araç: Id=1,BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=200,Description=" 50000 km'de            
//Car car1 = new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2005, DailyPrice =185, Description=" 50000 km'deki aracın fiyatı güncellendi"};
//carManager.Update(car1);            
//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);
//}

//Console.WriteLine("--------------------");
//Console.WriteLine("***Id No'su 2 Olan Aracın Silinmesi ve Araçların Yeniden Listelenmesi***");
//Car car2 = new Car { Id = 2 };
//carManager.Delete(car2);

//foreach (var car in carManager.GetAll())
//{
//    Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);

//}

//Console.WriteLine("--------------------");
//Console.WriteLine("***Id No'su 3 Olan Aracın Diğer Bilgilerinin Getirilmesi***");
//Car car3 = carManager.GetById(3);
//Console.WriteLine("Araç Bilgileri: " + "Araç ID: " + car3.Id + "; Marka ID=" + car3.BrandId + "; Model Yıllı=" + car3.ModelYear + "; Renk ID=" + car3.ColorId + "; Günlük Kirası=" + car3.DailyPrice + "; Açıklaması=" + car3.Description);

//Console.WriteLine("--------------------");
//Console.WriteLine("Araçlar, Günlük kirasına göre azalan olarak sıralansın***");

//carManager.Sorted();

//foreach (var car in carManager.Sorted())
//{
//    Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);

//}
