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
        protected virtual IRepository<T> Repository
        {
            get
            {
                return new ObjectRepository<T>();
            }
        }

        public virtual T GetObject(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            var TObject = this.Repository.FindBy(predicate);
            this.Repository.Dispose();
            return TObject.SingleOrDefault();
        }

        public virtual T GetObjectByID(int id)
        {
            return GetObject(x => x.ID == id);
        }

        public virtual List<T> GetObjects()
        {
            var TObjects = this.Repository.GetAll();
            this.Repository.Dispose();
            return TObjects.ToList();
        }

        public virtual T CreateObject(T entity)
        {
            var TObject = this.Repository.Add(entity);
            this.SaveChanges();
            return TObject;
        }

        public virtual void DeleteObject(T entity)
        {
            var TObject = this.Repository.Delete(entity);
            this.SaveChanges();            
        }

        public virtual T UpdateObject(T entity)
        {
            var TObject = this.Repository.Edit(entity);
            this.SaveChanges();
            return TObject;
        }

        protected virtual void SaveChanges()
        {
            this.Repository.Save();
            this.Repository.Dispose();
        }
       
    }
}
