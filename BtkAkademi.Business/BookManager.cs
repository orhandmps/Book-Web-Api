using BtkAkademi.Business.Concrete;
using BtkAkademi.DataAccess.Concrete;
using BtkAkademi.Domain.Entites;

namespace BtkAkademi.Business
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager manager;

        public BookManager(IRepositoryManager manager)
        {
            this.manager = manager;
        }

        public Book Add(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            manager.Book.Add(book);
            manager.Save();
            return book;
        }

        public void Delete(int id)
        {
            var book = manager.Book.Get(x => x.Id == id);
            if (book == null)
                throw new Exception("{id}:is null");
            manager.Book.Delete(book);
            manager.Save();
        }

        public Book Get(int id)
        {
            var book= manager.Book.Get(x => x.Id == id);
            return book;
        }

        public List<Book> GetAll()
        {
            return manager.Book.GetAll();
        }

        public void Update(int id, Book book)
        {
            var books = manager.Book.Get(x => x.Id == id);
            if (books == null)
                throw new Exception("{id}:is null");

            books.Title = book.Title;
            books.Price = book.Price;
            manager.Book.Update(book);
            manager.Save();
        }
    }
}
