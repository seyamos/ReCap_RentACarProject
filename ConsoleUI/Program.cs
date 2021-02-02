using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("***Tüm Araçların Listesi***");
            
            foreach (var car in carManager.GetAll())
            {                
                Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: "  + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("***Yeni Bir Aracın Eklenmesi ve Araçların Yeniden Listelenmesi***");
            Car car6 = new Car() { Id = 6, BrandId = 3, ColorId = 4, ModelYear = 2022, DailyPrice = 900, Description = "     0 km" };            
            carManager.Add(car6);            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("***Id No'su 1 Olan Aracın Güncellenmesi ve Araçların Yeniden Listelenmesi***");
            //Güncellenecek Araç: Id=1,BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=200,Description=" 50000 km'de            
            Car car1 = new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2005, DailyPrice =185, Description=" 50000 km'deki aracın fiyatı güncellendi"};
            carManager.Update(car1);            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("***Id No'su 2 Olan Aracın Silinmesi ve Araçların Yeniden Listelenmesi***");
            Car car2 = new Car { Id = 2 };
            carManager.Delete(car2);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.Id + ", Marka ID: " + car.BrandId + ", Model Yılı: " + car.ModelYear + ", Renk ID: " + car.ColorId + ", Günlük Kirası: " + car.DailyPrice + ", Açıklama: " + car.Description);

            }

            Console.WriteLine("--------------------");
            Console.WriteLine("***Id No'su 3 Olan Aracın Diğer Bilgilerinin Getirilmesi***");
            Car car3 = carManager.GetById(3);
            Console.WriteLine("Araç Bilgileri: " + "Araç ID: " + car3.Id + "; Marka ID=" + car3.BrandId + "; Model Yıllı=" + car3.ModelYear + "; Renk ID=" + car3.ColorId + "; Günlük Kirası=" + car3.DailyPrice + "; Açıklaması=" + car3.Description);


        }
    }
}
