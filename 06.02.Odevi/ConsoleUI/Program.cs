using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

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


            Console.WriteLine("\n\nAraçların Detaylı Listesi: \nCarId\tBrand Name\tColor Name\tModel Year\tDescriptions\tDaily Price");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine($"{car.CarId}\t{car.BrandName}\t\t{car.ColorName}\t\t{car.ModelYear}\t\t{car.Descriptions}\t\t{car.DailyPrice}");
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("***Yeni Bir Aracın Eklenmesi ve Araçların Yeniden Listelenmesi***");
            Car car1 = new Car()
            {
                BrandId = 3,
                ColorId = 1,
                DailyPrice = 500,
                Descriptions = "Yeni Eklenen Araç",
                ModelYear = "2021"
            };
            carManager.Add(car1);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.ModelYear + "/" + car.Descriptions);
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("***Id No'su 5010 Olan Aracın Silinmesi ve Araçların Yeniden Listelenmesi***");
            Car car5010 = carManager.GetById(5010);
            carManager.Delete(car5010);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("***Id No'su 5011 Olan Aracın Güncellenmesi ve Araçların Yeniden Listelenmesi***");
            Car car5011 = carManager.GetById(5011);
            car5011.DailyPrice = 700;
            car5011.Descriptions = " Fiyat Değiştirildi";
            carManager.Update(car5011);
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);
            }



            Console.WriteLine("Diğer Operasyonlar");
            Console.WriteLine("------------");
            Console.WriteLine("Car Id'si 3 Olan Arabanın Özellikleri");
            Car carId = carManager.GetById(3);
            Console.WriteLine(carId.CarId + "/" + carId.DailyPrice + "/" + carId.ModelYear + "/" + carId.Descriptions);

            Console.WriteLine("------------");
            Console.WriteLine("Brand Id'si 1 Olan Arabanın Özellikleri");
            Brand brandId = brandManager.GetById(1);
            Console.WriteLine(brandId.BrandId + "/" + brandId.BrandName);

            Console.WriteLine("------------");
            Console.WriteLine("Color Id'si 3 Olan Arabanın Özellikleri");
            Color colorId = colorManager.GetById(3);
            Console.WriteLine(colorId.ColorId + "/" + colorId.ColorName);

            Console.WriteLine("------------");
            Console.WriteLine("Araç Renkleri");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }

            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 165 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(100, 165))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }

            


        }
    }
}