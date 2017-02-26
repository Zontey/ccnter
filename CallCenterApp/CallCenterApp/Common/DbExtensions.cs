using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterApp.Common
{
    public class DbExtensions
    {
        protected IQueryable<T> List<T>(DbContext context) where T : class
        {
            return context.Set<T>().AsNoTracking();
        }

        public T Insert<T>(T entity, DbContext context) where T : class
        {
            context.Set<T>().Add(entity);
            return entity;
        }

        protected void Delete<T>(T entity, DbContext context) where T : class
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Deleted;
        }

        protected void Update<T>(T entity, DbContext context) where T : class
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
