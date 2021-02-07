# ReCapProject_RentACar (Odev1)

Araba kiralama sistemi yazıyoruz.

1. Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak. (Tekrar ve geliştirme projesi)

2. Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

3. Bir araba nesnesi oluşturunuz. "Car"

4. Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

5. InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

6. Consolda test ediniz.

# ReCapProject_RentACar (Odev2 - Geliştirmelere Devam)

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
