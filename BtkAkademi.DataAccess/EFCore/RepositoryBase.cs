using BtkAkademi.DataAccess.Concrete;
using System.Linq.Expressions;

namespace BtkAkademi.DataAccess.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {

        protected readonly BtkContext context;

        public RepositoryBase(BtkContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
            var entities=context.Set<T>().ToList();
            return entities;
        }


        public T Get(Expression<Func<T, bool>> filter)
        {
            var entity = context.Set<T>().Where(filter).FirstOrDefault();
            return entity;
        }

        public void Update(T entit)
        {
            context.Set<T>().Update(entit);
        }
    }
}
