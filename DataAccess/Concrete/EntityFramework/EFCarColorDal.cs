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
   public class EFCarColorDal : ICarColorDal
    {
        public void Add(CarColor entity)
        {
            using (carcontext context=new carcontext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Delete(CarColor entity)
        {
            using (carcontext context = new carcontext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Deleted;
            }
        }

        public CarColor Get(Expression<Func<CarColor, bool>> filter)
        {
            using (carcontext context=new carcontext())
            {
                return context.Set<CarColor>().SingleOrDefault(filter);
            }
        }

        public List<CarColor> GetAll(Expression<Func<CarColor, bool>> filter = null)
        {
            using (carcontext context = new carcontext())
            {
                return filter == null ? context.Set<CarColor>().ToList() : context.Set<CarColor>().Where(filter).ToList();
            }
        }

        public void Update(CarColor entity)
        {
            using (carcontext context = new carcontext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
