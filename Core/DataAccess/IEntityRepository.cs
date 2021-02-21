
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        public T Add(T item);
        public void Delete(T item);//Objeye göre de silinebilir


        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
        public T Get(Expression<Func<T, bool>> filter);
        //T Get(Expression<Func<T, bool>> filter);

        public T Update(T item);
    }
}
