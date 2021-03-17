using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages  //static yaparsak new lememize gerek kalmaz
    {
        public static string CarAdded = "Araç eklendi";
        public static string CarDailyPriceInvalid = "Araç fiyatı geçersiz.Girilen fiyat 0'dan büyük olmalıdır";        
        public static string CarsListed="Araçlar listelendi";
        public static string CarNameInvalid = "Araç ismi geçersiz. Araç ismi en az 2 karakter olmalıdır";

        public static string BrandNameInvalid = "Marka ismi geçersiz. Marka ismi en az 2 karakter olmalıdır";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandsListed = "Markalar Listelendi";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorsListed = "Renkler Listelendi";

        public static string RentalAdded = "Araç Kiralama gerçekleşti.";
        public static string RentalUpdated = "Araç Kiralama güncellendi.";
        public static string UndeliveredCar = "Bu araç henüz teslim edilmediği için kiralanamaz.";
        

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UsersListed = "Kullanıcılar Listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerListed = "Müşteriler Listelendi";

        public static string CarImageListed = "Resim Listelendi";
        public static string CarImageAdded = "Resim eklendi";        
        public static string CarImageDeleted = "Resim silindi";
        public static string CarImageUpdated = "Resim güncellendi";
        public static string CarImageLimitExceeded = "Resim sayısı en fazla 5 olabilir";

        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kullanıcı başarıyla kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatalı.";
        public static string SuccessfulLogin = "Sisteme giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu.";



        //public static string BrandNameInvalid = "Araç ismi geçersiz";  //CarName ekleyerek DB'ye burayı düzelt kendime not.
    }
}

