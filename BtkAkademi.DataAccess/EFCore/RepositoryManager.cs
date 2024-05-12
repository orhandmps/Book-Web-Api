using BtkAkademi.DataAccess.Concrete;

namespace BtkAkademi.DataAccess.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {

        private readonly BtkContext context;
        private readonly Lazy<IBookRepository> bookRepository;

        public RepositoryManager(BtkContext context)
        {
            this.context = context;
            bookRepository = new Lazy<IBookRepository>(() => new BookRespoitory(context));
        }

        public IBookRepository Book => bookRepository.Value;

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
