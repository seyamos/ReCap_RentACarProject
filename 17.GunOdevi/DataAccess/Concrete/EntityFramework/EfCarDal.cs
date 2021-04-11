using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        //public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context =new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join y in context.Colors
                             on c.ColorId equals y.ColorId
                             //from ca in context.Cars
                             //join im in context.CarImages
                             //on ca.CarId equals im.CarId

                             select new CarDetailDto 
                             {
                                 CarId = c.CarId, 
                                 CarName=c.CarName, 
                                 BrandName=b.BrandName,                                 
                                 ColorName=y.ColorName,                                 
                                 ModelYear=c.ModelYear, 
                                 Descriptions=c.Descriptions, 
                                 DailyPrice=c.DailyPrice,
                                 BrandId = b.BrandId,
                                 ColorId = y.ColorId,
                                 ImagePath = (from a in context.CarImages where a.CarId == c.CarId select a.ImagePath).FirstOrDefault()
                                 //ImagePath = context.CarImages.Where(ci => ci.CarId == c.CarId).FirstOrDefault().ImagePath

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
                //return result.ToList();
                }
        }

        
    }
}
