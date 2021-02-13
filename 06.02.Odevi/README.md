# ReCapProject_RentACar (Odev1)

Araba kiralama sistemi yazıyoruz.

1. Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

2. Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

3. Bir araba nesnesi oluşturunuz. "Car"

4. Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

5. InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

6. Consolda test ediniz.

# ReCapProject_RentACar (Odev2- 03/02  Geliştirmelere Devam)

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

# ReCapProject_RentACar (Odev3- 06/02  Geliştirmelere Devam)

1. CarRental Projenizde Core katmanı oluşturunuz.

2. IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarınızı 9. gün dersindeki gibi oluşturup ekleyiniz.

3. Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını hazır hale getiriniz.

4. Console'da Tüm CRUD operasyonlarınızı Car, Brand, Model nesneleriniz için test ediniz. GetAll, GetById, Insert, Update, Delete.

5. Arabaları şu bilgiler olacak şekilde listeleyiniz. CarName, BrandName, ColorName, DailyPrice. (İpucu : IDto oluşturup 3 tabloya join yazınız)




