using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MailableMe.Data;
using System.Linq.Expressions;

namespace MailableMe.Service.Core
{
    public interface IRepository<T> where T:BaseObject
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
