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
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context =new RentACarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join y in context.Colors
                             on c.ColorId equals y.ColorId
                             select new CarDetailDto 
                             {
                                 CarId = c.CarId, BrandName=b.BrandName, ColorName=y.ColorName, ModelYear=c.ModelYear, Descriptions=c.Descriptions, DailyPrice=c.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
