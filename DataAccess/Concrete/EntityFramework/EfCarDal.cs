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
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RantACarContext context=new RantACarContext())
            {
                var addedEntity = context.Entry(entity); //Referansı yakala
                addedEntity.State = EntityState.Added; //O aslında eklenecek bir nesne
                context.SaveChanges(); //Ekle
            }
        }

        public void Delete(Car entity)
        {
            using (RantACarContext context=new RantACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RantACarContext context=new RantACarContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RantACarContext context=new RantACarContext())
            {
                return filter == null             // filtre var mı yok mu?
                    ? context.Set<Car>().ToList() // yoksa DbSet'teki Car tablosuna yerleş veritabanındaki bütün tabloyu listeye çevir ve onu bana ver,
                    : context.Set<Car>().Where(filter).ToList(); //filtre varsa filtreleyip ver.
            }
        }

        public void Update(Car entity)
        {
            using (RantACarContext context=new RantACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}