using MyApp.DTO;
using MyApp.Model;

namespace MyApp.IServices
{
    public interface IBookService
    {
        public Task<GetBookDto> CreateBookAsync(CreateBookDto bookDto);
        public Task<GetBookDto> UpdateBookAsync(int id, UpdateBookDto bookDto);
        public Task<bool> DeleteBookAsync(int id);
        public Task<GetBookDto> GetBookAsync(int id);
        public Task<IEnumerable<GetBookDto>> GetBooksAsync();
    }
}
