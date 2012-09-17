using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.Linq.Expressions;

namespace MailableMe.Service.Core
{
    public interface IObjects<T> where T:BaseObject
    {
        IQueryable<T> GetObject(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetObjects();
        T CreateObject(T entity);
        T DeleteObject(T entity);
        T UpdateObject(T entity);
    }
}
