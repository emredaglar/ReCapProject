using Core.DataAccess.EntityFreamwork;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFreamwork
{
    public class EfCarDal : EfEntityFreamworkBase<Car, ReCapContext>, ICarDal
    {
        //public void Add(Car entity)
        //{
        //    using (ReCapContext context=new ReCapContext())
        //    {
        //        var addedContext=context.Entry(entity);
        //        addedContext.State=EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void Delete(Car entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var deletedContext = context.Entry(entity);
        //        deletedContext.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    using (ReCapContext context=new ReCapContext())
        //    {
        //        return context.Set<Car>().SingleOrDefault();
        //    }
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    using (ReCapContext context=new ReCapContext())
        //    {
        //        return filter==null
        //            ? context.Set<Car>().ToList() 
        //            : context.Set<Car>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Car entity)
        //{
        //    using (ReCapContext context = new ReCapContext())
        //    {
        //        var updatedContext = context.Entry(entity);
        //        updatedContext.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
        public List<GetCarDetailsDto> GetCarDetails()
        {
            using (ReCapContext context=new ReCapContext())
            {
                //var result = from c in context.Cars
                //             join b in context.Brands on c.BrandId equals b.BrandId
                //             join r in context.Colors on c.ColorId equals r.ColorId
                //             select new GetCarDetailsDto
                //             {


                //                 CarName = c.CarName,

                //                 BrandName = b.BrandName,
                //                 ColorName=r.ColorName,
                //                 DailyPrice=c.DailyPrice,
                //             };
                //return result.ToList();
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             select new GetCarDetailsDto
                             {
                                 CarId = c.CarId,
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();


            }
        }
    }
}
