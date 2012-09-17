using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using MailableMe.Service.Repository;

namespace MailableMe.Service.Core
{
    public abstract class BaseClass<T> : IObjects<T> where T : BaseObject
    {        

        public IQueryable<T> GetObject(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            using (IRepository<T> rep = new GenericRepository<T>())
            {
                return rep.FindBy(predicate);
            }
        }

        public IQueryable<T> GetObjects()
        {
            using (IRepository<T> rep = new GenericRepository<T>())
            {
                return rep.GetAll();
            }
        }

        public T CreateObject(T entity)
        {
            using (IRepository<T> rep = new GenericRepository<T>())
            {
                rep.Add(entity);
                this.Save(rep);
                return entity;
            }
        }

        public T DeleteObject(T entity)
        {
            using (IRepository<T> rep = new GenericRepository<T>())
            {
                rep.Delete(entity);
                this.Save(rep);
                return entity;
            }
        }

        public T UpdateObject(T entity)
        {
            using (IRepository<T> rep = new GenericRepository<T>())
            {
                rep.Edit(entity);
                this.Save(rep);
                return entity;
            }
        }

        void Save(IRepository<T> rep)
        {
            rep.Save();
        }
    }
}
