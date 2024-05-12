using System.Linq.Expressions;

namespace BtkAkademi.DataAccess.Concrete
{
    public interface IRepositoryBase<T>
    {
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entit);
        void Delete(T entity);

    }
}
