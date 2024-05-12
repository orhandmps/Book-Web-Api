namespace BtkAkademi.DataAccess.Concrete
{
    public interface IRepositoryManager
    {
        IBookRepository Book {  get; }
        void Save();
    }
}
