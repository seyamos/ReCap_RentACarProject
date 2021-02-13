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

            

            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 165 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(100, 165))
            {
                Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }
            

            Console.WriteLine("------------");
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            }

            Console.WriteLine("------------");
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }


            Console.WriteLine("------------");
            Console.WriteLine("Günlük Fiyatı 100 tl ile 200 tl arasında olan araçlar:");
            foreach (var car in carManager.GetByDailyPrice(100, 200))
            {
                Console.WriteLine(car.CarId + "/" + car.DailyPrice);
            }


            Console.WriteLine("------------");
            Console.WriteLine("Car Id'si 3 Olan Arabanın Özellikleri");
            Car carId = carManager.GetById(3);
            Console.WriteLine(carId.CarId + "/"+ carId.DailyPrice + "/" + carId.ModelYear + "/" + carId.Descriptions);

            Console.WriteLine("------------");
            Console.WriteLine("Brand Id'si 1 Olan Arabanın Özellikleri");
            Brand brandId = brandManager.GetById(1);
            Console.WriteLine(brandId.BrandId + "/" + brandId.BrandName);

            
            Console.WriteLine("------------");
            Console.WriteLine("Color Id'si 3 Olan Arabanın Özellikleri");
            Color colorId = colorManager.GetById(3);
            Console.WriteLine(colorId.ColorId + "/" + colorId.ColorName);
            




            //Console.WriteLine("\n\nTüm Araçların Listesi: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine($"{car.CarId}\t{car.BrandName}\t\t{car.ColorName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            //}

            
            Console.WriteLine("Brand Id'si 1 Olan Araçlar:");
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.BrandId + "/"+ brandManager.GetById(car.BrandId).BrandName + "/" + car.DailyPrice + "/" + car.ModelYear + "/" + car.Descriptions);
            }


            //Console.WriteLine("--------------------");
            //Console.WriteLine("***Yeni Bir Aracın Eklenmesi ve Araçların Yeniden Listelenmesi***");
            //Car car1 = new Car()
            //{

            //    BrandId = 3,
            //    ColorId = 1,
            //    DailyPrice = 500,
            //    Descriptions = "Yeni Eklenen Araç",
            //    ModelYear = "2021"
            //};

            //carManager.Add(car1);
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarId + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.ModelYear + "/" + car.Descriptions);

            //}

            //Console.WriteLine("--------------------");
            //Console.WriteLine("***Id No'su 5007 Olan Aracın Silinmesi ve Araçların Yeniden Listelenmesi***");
            //Car car5007 = new Car { CarId = 5007 };
            //carManager.Delete(car5007);

            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);

            //}

            Console.WriteLine("--------------------");
            Console.WriteLine("***Id No'su 3 Olan Aracın Güncellenmesi ve Araçların Yeniden Listelenmesi***");
            Car car1 = carManager.GetById(3);
            car1.DailyPrice =800;
            car1.Descriptions = "Güncellenen Araç";            
            carManager.Update(car1);
            
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);
            }

            



            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandName);
            //}




            //foreach (var car in carManager.GetByDailyPrice(100, 150))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}\t\t{car.BrandId}");
            //}



            //Console.WriteLine("Brand Id'si 1 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            //}

            //Console.WriteLine("\n\nColor Id'si 2 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //foreach (var car in carManager.GetCarsByColorId(2))
            //{
            //    Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            //}

            //Console.WriteLine("\n\nCar Id'si 3 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions");
            //Car carById = carManager.GetById(3);
            //Console.WriteLine($"{carById.CarId}\t{colorManager.GetById(carById.ColorId).ColorName}\t\t{brandManager.GetById(carById.BrandId).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}\t\t{carById.Descriptions}");




            //Console.WriteLine("\n");

            //carManager.Add(new Car {BrandId = 3, ColorId = 3, DailyPrice = 500, ModelYear = "2022", Descriptions = "Otomatik Uçan" });
            //brandManager.Add(new Brand { BrandName = "Renault" });

            //Console.WriteLine("\n");

            //Console.WriteLine("Id No'su 4003 Olan Aracın Silinmesi ve Araçların Yeniden Listelenmesi");
            //carManager.Delete(new Car { CarId = 4003 });

            //carmanager.getall();
            //console.writeline("\n\ntüm araçların listesi: \nıd\tcolor name\tbrand name\tmodel year\tdaily price\tdescriptions");
            //foreach (var car in carmanager.getall())
            //{
            //    console.writeline($"{car.carıd}\t{colormanager.getbyıd(car.colorıd).colorname}\t\t{brandmanager.getbyıd(car.brandıd).brandname}\t\t{car.modelyear}\t\t{car.dailyprice}\t\t{car.descriptions}");
            //}





            //brandManager.Delete(new Brand { BrandId = 1002 });
            //brandManager.Delete(new Brand { BrandId = 1003 });
            //brandManager.Delete(new Brand { BrandId = 1004 });
            //brandManager.Delete(new Brand { BrandId = 1005 });
            //brandManager.Delete(new Brand { BrandId = 1006 });
            //brandManager.Delete(new Brand { BrandId = 1007 });
            //brandManager.Delete(new Brand { BrandId = 2002 });
            //brandManager.Delete(new Brand { BrandId = 2003 });
            //brandManager.Delete(new Brand { BrandId = 2004 });
            //brandManager.Delete(new Brand { BrandId = 3002 });
            //brandManager.Delete(new Brand { BrandId = 4002 });
            //brandManager.Delete(new Brand { BrandId = 4003 });
            //brandManager.Delete(new Brand { BrandId = 4004 });
            //brandManager.Delete(new Brand { BrandId = 4005 });
            //brandManager.Delete(new Brand { BrandId = 4006 });
            //    brandManager.Delete(new Brand { BrandId = 4 });
            //    brandManager.Delete(new Brand { BrandId = 5 });

            //    Console.WriteLine("\n\nTüm Araçların Listesi: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price\tDescriptions\tBrand Id");
            //    foreach (var car in carManager.GetAll())
            //    {
            //        Console.WriteLine($"{car.CarId}\t{colorManager.GetById(car.ColorId).ColorName}\t\t{brandManager.GetById(car.BrandId).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}\t\t{car.BrandId}");

            //    }

            //}

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
