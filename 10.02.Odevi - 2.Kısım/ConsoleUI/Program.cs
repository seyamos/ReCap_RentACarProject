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
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            Console.WriteLine("Yeni Kullanıcı Ekleme");
            User user1 = new User()
            {
                FirstName = "Cem",
                LastName = "Kale",
                Email = "CemKale@gmail.com",
                Password = "2222"
            };

            var result2 = userManager.Add(user1);
            if (result2.Success == true)
            {
                Console.WriteLine(result2.Message);

                foreach (var user in userManager.GetAll().Data)
                {
                    Console.WriteLine(user.UserId + " / " + user.FirstName + " / " + user.LastName
                        + " / " + user.Email + " / " + user.Password);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }


            Console.WriteLine("----------");
            Console.WriteLine("Araç Kiralama");
            
            var result1 = rentalManager.Add(new Rental
            {
                CarId = 1,
                CustomerId = 14,
                RentDate = DateTime.Today
            });

            Console.WriteLine(result1.Message);






            Console.WriteLine("Önceki Operasyonlar");
            Console.WriteLine("Araçların Detaylı Listesi");
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " / " + car.CarName + " / "
                        + car.BrandName + " / " + car.ColorName + " / "
                        + car.ModelYear + " / " + car.DailyPrice + " / "
                        + car.Descriptions);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            Console.WriteLine("--------------------");
            Console.WriteLine("\n\nGetAll Operasyonu\nAraç Listesi: \nCarId\tCar Name\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine($"{car.CarId}\t{car.CarName}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("Araç Ekleme Operasyonu ve Araçların Yeniden listelenmesi");
            Car car1 = new Car()
            {
                BrandId = 1,
                ColorId = 3,
                CarName = "R",
                DailyPrice = 750,
                Descriptions = "Yeni eklenen Araç",
                ModelYear = "2000",
            };

            var result6 = carManager.Add(car1);

            if (result6.Success == true)
            {
                Console.WriteLine(result6.Message);

                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result6.Message);
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("Araç Silme Operasyonu ve Araçların Yeniden Listelenmesi");
            Car car8012 = carManager.GetById(8012).Data;
            carManager.Delete(car8012);
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + " / " + car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Araç Güncelleme Operasyonu ve Araçların Yeniden Listelenmesi");
            Car car5 = carManager.GetById(5).Data;
            car5.CarName = "Tesla Yeni";
            car5.DailyPrice = 800;
            car5.Descriptions = "Full Otomatik";
            car5.BrandId = 5006;
            car5.ModelYear = "2023";
            carManager.Update(car5);
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + " / " + car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("Marka Ekleme Operasyonu ve Markaların Listelenmesi");
            Brand brand5 = new Brand()
            {
                BrandName = "B"
            };

            var result5 = brandManager.Add(brand5);

            if (result5.Success == true)
            {
                Console.WriteLine(result5.Message);

                foreach (var brand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result5.Message);
            }


            Console.WriteLine("--------------------");
            Console.WriteLine("Renk Güncelleme Operasyonu && Renklerin ve Araçların Yeniden Listelenmesi");
            Color colorId = colorManager.GetById(3).Data;
            colorId.ColorName = "Kahverengi";
            colorManager.Update(colorId);
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }

            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarId + " / " + car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice + " / " + car.ModelYear + " / " + car.Descriptions);
            }



            Console.WriteLine("--------------------");
            Console.WriteLine("Diğer Operasyonlar");
            Console.WriteLine("Car Id'si 3 Olan Arabanın Özellikleri");
            Car carId = carManager.GetById(3).Data;
            Console.WriteLine(carId.CarId + " / " + carId.CarName + " / "
                 + carId.DailyPrice + " / " + carId.Descriptions);


            //Console.WriteLine("--------------------");
            //Console.WriteLine("Brand Id'si 1 Olan Arabanın Özellikleri");
            //Brand brandId = brandManager.GetById(1).Data;
            //Console.WriteLine(brandId.BrandId + " / " + brandId.BrandName);

            Console.WriteLine("--------------------");
            Console.WriteLine("Brand Id'si 1 Olan Arabanın Özellikleri");
            foreach (var car in carManager.GetAllByBrandId(1).Data)
            {
                Console.WriteLine(car.BrandId + " / " + car.CarName + " / ");
            }

            //Console.WriteLine("--------------------");
            //Console.WriteLine("Color Id'si 3 Olan Arabanın Özellikleri");
            //Color colorid = colorManager.GetById(3).Data;
            //Console.WriteLine(colorid.ColorId + "/" + colorid.ColorName);

            Console.WriteLine("--------------------");
            Console.WriteLine("Color Id'si 3 Olan Arabanın Özellikleri");
            foreach (var car in carManager.GetAllByColorId(3).Data)
            {
                Console.WriteLine(car.BrandId + " / " + car.CarName);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Tüm Araç Renkleri");
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorId + "/" + color.ColorName);
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("Tüm Markalar");
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            }

            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 300 olan arabalar: \nCar Id\tModel Year\tDaily Price\tDescriptions");
            foreach (var car in carManager.GetByDailyPrice(100, 300).Data)
            {
                Console.WriteLine($"{car.CarId}\t\t{car.ModelYear}\t\t{car.DailyPrice}\t\t{car.Descriptions}");
            }



        }
    }
}