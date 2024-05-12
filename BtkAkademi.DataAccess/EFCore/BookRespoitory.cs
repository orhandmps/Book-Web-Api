using BtkAkademi.DataAccess.Concrete;
using BtkAkademi.Domain.Entites;

namespace BtkAkademi.DataAccess.EFCore
{
    public class BookRespoitory : RepositoryBase<Book>, IBookRepository
    {
        public BookRespoitory(BtkContext context) : base(context)
        {
        }

    }
}
