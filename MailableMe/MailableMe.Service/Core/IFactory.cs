using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.Linq.Expressions;

namespace MailableMe.Service.Core
{
    public interface IFactory<T> where T:BaseObject
    {
        T GetObject(Expression<Func<T, bool>> predicate);
        T GetObjectByID(int id);
        List<T> GetObjects();
        T CreateObject(T entity);
        void DeleteObject(T entity);
        T UpdateObject(T entity);
    }
}
