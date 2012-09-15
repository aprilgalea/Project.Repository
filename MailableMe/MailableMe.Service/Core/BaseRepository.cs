using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.Data.Entity;


namespace MailableMe.Service.Core
{
    public abstract class BaseRepository<T,C> : IRepository<T>, IDisposable
        where T:BaseObject
        where C: DbContext,new()
    {
        private C _context;        

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = System.Data.EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public void Dispose()
        {
            this._context.Dispose();
        }
    }
}
