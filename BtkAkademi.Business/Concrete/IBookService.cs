using BtkAkademi.Domain.Entites;

namespace BtkAkademi.Business.Concrete
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Get(int id);
        Book Add(Book book);
        void Update(int id, Book book);
        void Delete(int id);
    }
}
