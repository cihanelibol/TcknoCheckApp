using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TcknoCheckApp.DataAccess.EFramework
{
    public interface IEfRepository<T> where T : class, new()
    {
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
