using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.Linq.Expressions;

namespace MailableMe.Service.Core
{
    public interface IRepository<T>: IDisposable where T:BaseObject
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        T Edit(T entity);
        void Save();
    }
}
