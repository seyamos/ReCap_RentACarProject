# ReCapProject_RentACar (Odev1)

Araba kiralama sistemi yazıyoruz.

1. Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

2. Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

3. Bir araba nesnesi oluşturunuz. "Car"

4. Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

5. InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

6. Consolda test ediniz.

# ReCapProject_RentACar (Odev2- 03/02  Geliştirmeleri)

Car nesnesine ek olarak;

1. Brand ve Color nesneleri ekleyiniz(Entity)

Brand-->Id,Name

Color-->Id,Name

2. Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)

3. Sisteme Generic IEntityRepository altyapısı yazınız.

4. Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

5. GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

6. Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

# ReCapProject_RentACar (Odev3- 06/02  Geliştirmeleri)

1. CarRental Projenizde Core katmanı oluşturunuz.

2. IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.

3. Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.

4. Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.

5. Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)

# ReCapProject_RentACar (Odev4- 10/02  Geliştirmeleri-1)

1. Core katmanında Results yapılandırması yapınız.

2. Daha önce geliştirdiğiniz tüm Business sınıflarını bu yapıya göre refactor (kodu iyileştirme) ediniz.

# ReCapProject_RentACar (Odev4- 10/02  Geliştirmeleri-2.Kısım)

CarRental projenizde;

1. Kullanıcılar tablosu oluşturunuz. Users-->Id,FirstName,LastName,Email,Password

2. Müşteriler tablosu oluşturunuz. Customers-->UserId,CompanyName  -- Kullanıcılar ve müşteriler ilişkilidir.

3. Arabanın kiralanma bilgisini tutan tablo oluşturunuz. Rentals-->Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi). Araba teslim edilmemişse ReturnDate null'dır.

4. Projenizde bu entity'leri oluşturunuz.

5. CRUD operasyonlarını yazınız.

6. Yeni müşteriler ekleyiniz.

7. Arabayı kiralama imkanını kodlayınız. Rental-->Add  --- Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.

# ReCapProject_RentACar (Odev6- 13/02  Geliştirmeleri)

CarRental projenizde;

1. WebAPI katmanını kurunuz. ----> ✔ Kuruldu 

2. Business katmanındaki tüm servislerin Api karşılığını yazınız. ----> ✔ Yazıldı

3. Postman'de test ediniz.----> ✔ Test edildi

Öğrendiklerimiz: 
*WebApi oluşturmak
*Controller yazmak
*IoC Prensibi'ni uygulamak
*Projeyi Postman'de test etmek

# ReCapProject_RentACar (Odev7- 17/02  Geliştirmeleri)

1.Car Rental Projenize Autofac desteği ekleyiniz ----> ✔ Autofac eklendi

2. Car Rental Projenize FluentValidation desteği ekleyiniz----> ✔ FluentValidation eklendi (bir kaç ek daha yapılacak)

3. Car Rental Projenize AOP desteği ekleyiniz. ----> ✔ AOP desteği eklendi
   ValidationAspect ekleyiniz.----> ✔ ValidationAspect eklendi
   
# ReCapProject_RentACar (Odev8- 27/02  Geliştirmeleri)
  
  RentACar projenize JWT entegrasyonu yapınız. ✔ JWT eklendi
  
# ReCapProject_RentACar (Odev9- 10/03 - 17.Gun Geliştirmeleri, Frontend İçin)

  rentals, cars, brands, customers, users tabloları join edildi ✔ (EfRentalDal, RentalDetailDto, RentACarContext)

  localhost eklendi ✔ (WebApi, Startup)

  Thread.Sleep() eklendi ✔ (Controllers)  
