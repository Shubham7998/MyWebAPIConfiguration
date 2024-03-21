using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.IServices
{
    public interface IAuthorService
    {
        public Task<Author> CreateAuthorAsync(Author author);

        public Task<Author> UpdateAuthorAsync(int id, Author author);
        public Task<bool> DeleteAuthorAsync(int id);
        public Task<Author> GetAuthorAsync(int id);
        public Task<IEnumerable<Author>> GetAuthorAsync();
    }
}
