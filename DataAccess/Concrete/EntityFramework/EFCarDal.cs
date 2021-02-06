using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter); //tek bir car datası getirecek.
            }
            
        }
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null //filter boş mu? 
                    ? context.Set<Car>().ToList() //filter boş ise tüm datayı getir.
                    : context.Set<Car>().Where(filter).ToList(); //değilse filter uygula liste olarak gerir. 
            }
        }

        public List<Car> GetCarByBrandId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
