using MyApp.IRepositories;
using MyApp.IServices;
using MyApp.Model;

namespace MyApp.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

         public Task<Author> CreateAuthorAsync(Author author)
        {
            return _authorRepository.CreateAsync(author);
        }

        public async Task<bool> DeleteAuthorAsync(int id)
        {
            var isAuthorPresent = await _authorRepository.GetByIdAsync(id);

            if(isAuthorPresent != null)
            {
                return await _authorRepository.DeleteAsync(isAuthorPresent);
            }
            return false;
        }

        public async Task<Author> GetAuthorAsync(int id)
        {
            return await _authorRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Author>> GetAuthorAsync()
        {
            return await _authorRepository.GetAllAsync();
        }

        public async Task<Author> UpdateAuthorAsync(int id, Author author)
        {
            var oldAuthor = await _authorRepository.GetByIdAsync(id);

            if(oldAuthor != null)
            {
                oldAuthor.AuthorName = author.AuthorName;
                oldAuthor.AuthorEmail = author.AuthorEmail;

                await _authorRepository.UpdateAsync(oldAuthor);

                return oldAuthor;
            }
            return null;
        }
    }
}
