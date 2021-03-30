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
    public class EfCarDal : EfEntityRepositoryBase<Cars, CarRentalDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalDatabaseContext context=new CarRentalDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandName equals b.BrandName
                             select new CarDetailDto { BrandName = c.BrandName, DailyPrice = c.DailyPrice };
                return result.ToList();


            }
        }
    }
}
