using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using MailableMe.Service.Repository;

namespace MailableMe.Service.Core
{
    public abstract class BaseFactory<T> : IFactory<T> where T : BaseObject
    {
        private IRepository<T> Repository
        {
            get
            {
                return new ObjectRepository<T>();
            }
        }

        public IQueryable<T> GetObject(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var TObject = this.Repository.FindBy(predicate);
            this.Repository.Dispose();
            return TObject;
        }

        public IQueryable<T> GetObjects()
        {
            var TObjects = this.Repository.GetAll();
            this.Repository.Dispose();
            return TObjects;
        }

        public T CreateObject(T entity)
        {
            var TObject = this.Repository.Add(entity);
            this.SaveChanges();
            return TObject;
        }

        public T DeleteObject(T entity)
        {
            var TObject = this.Repository.Delete(entity);
            this.SaveChanges();
            return TObject;
        }

        public T UpdateObject(T entity)
        {
            var TObject = this.Repository.Edit(entity);
            this.SaveChanges();
            return TObject;
        }

        private void SaveChanges()
        {
            this.Repository.Save();
            this.Repository.Dispose();
        }
    }
}
