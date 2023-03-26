using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfGenericRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class
        where TContext : DbContext,new()
    {
        public void Add(TEntity t)
        {
            using (var context=new TContext())
            {
                context.Set<TEntity>().Add(t);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity t)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(t);
                context.SaveChanges();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public List<TEntity> List()
        {

            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity t)
        {
            using (TContext context = new TContext())
            {
                //var updatedenttiy = context.Entry(t);
                //updatedenttiy.State = EntityState.Modified;
                //context.SaveChanges();
                context.Update(t);
                context.SaveChanges();
            }
        }
    }
}
