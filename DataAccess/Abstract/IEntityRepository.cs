using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract

//generic constraint- generic kısıt :T için where ile başladığım bölüm.
//Kısıtları belirliyorum:
//class : referans tip olabilir demek. int olamaz mesela.  ICarDal bize hata verir int yaparsak orayı
//IEntity: IEntity olabilir ya da IEntity'den impl.eden bir nesne olabilir demek. 
//new : new lenebilir olmalı, IEntity new lenemez çünkü interface old için. ICarDal içine IEntity yazarsak kızarır artık.Sadece Car,Brand,Color gibi IEtitiy den implemente ettiklerimi kullanabilirim


{
    public interface IEntityRepository<T> where T:class,IEntity,new() //T'yi sınırlandırmak istiyorum. Herkes istediği Tyi getirmesin benim verdiğim şeyler gelsin
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //using system linq expression diyoruz. link kullanımını filtrelemeyi sağlamak için
        T Get(Expression<Func<T, bool>> filter);        //tek bir şeyin detayı için de bu. filtreleme yapmayacağımız için =null yapmamıza gerek yok burada

        //T GetById(int Id);  Artık buna ihtiyacımız kalmadı

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
