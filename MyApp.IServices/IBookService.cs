using MyApp.Model;

namespace MyApp.IServices
{
    public interface IBookService
    {
        public Task<Book> CreateBookAsync(Book book);
        public Task<Book> UpdateBookAsync(int id, Book book);
        public Task<bool> DeleteBookAsync(int id);
        public Task<Book> GetBookAsync(int id);
        public Task<IEnumerable<Book>> GetBooksAsync();
    }
}
