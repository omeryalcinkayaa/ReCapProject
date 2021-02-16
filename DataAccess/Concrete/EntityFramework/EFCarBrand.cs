using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class EFCarBrand : ICarBrand
    {
        public void Add(CarBrand entity)
        {
            using (carcontext context=new carcontext())
            {
                var addedbrand = context.Entry(entity);
                addedbrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CarBrand entity)
        {
            using (carcontext context=new carcontext())
            {
                var deletedbrand = context.Entry(entity);
                deletedbrand.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public CarBrand Get(Expression<Func<CarBrand, bool>> filter)
        {
            using (carcontext context=new carcontext())
            {
                return context.Set<CarBrand>().SingleOrDefault(filter);
            }           
        }
        public List<CarBrand> GetAll(Expression<Func<CarBrand, bool>> filter = null)
        {
            using (carcontext context=new carcontext())
            {
                return filter == null ? context.Set<CarBrand>().ToList() : context.Set<CarBrand>().Where(filter).ToList();
            }
        }

        public void Update(CarBrand entity)
        {
            using (carcontext context=new carcontext())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();
                    
            }
        }
    }
}
