using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TContext : DbContext, new() where TEntity : class, IEntity, new()
    {
        public TEntity Add(TEntity item)
        {
            using (var context=new TContext())
            {
                var entry=context.Entry(item);
                entry.State = EntityState.Added;
                context.SaveChanges();
                return item;
            }
        }

        public void Delete(TEntity item) //Silme yaparken diger tablolarla iliskili oldugundan hata veriyor
        {
            using (var context=new TContext())
            {
                    var entry = context.Entry(item);
                    entry.State = EntityState.Deleted;
                    context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context=new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context=new TContext())
            {
                if (filter == null)
                {
                    return context.Set<TEntity>().ToList();
                    
                }
                else
                {
                   return context.Set<TEntity>().Where(filter).ToList();
                   
                }
            }
        }

        public TEntity Update(TEntity item)
        {
            using (var context=new TContext())
            {
                var entry = context.Entry(item);
                entry.State = EntityState.Modified;
                return item;
            }
        }
    }
}
