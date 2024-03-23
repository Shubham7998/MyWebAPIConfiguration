using MyApp.IRepositories;
using MyApp.IServices;
using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> CreateBookAsync(Book book)
        {
            return await _bookRepository.CreateAsync(book);
        }

        public async Task<bool> DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);

            if (book != null)
            {
                return await _bookRepository.DeleteAsync(book);
            }
            return false;
        }

        public async Task<Book> GetBookAsync(int id)
        {
            return await _bookRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _bookRepository.GetAllAsync();
        }

        public async Task<Book> UpdateBookAsync(int id, Book book)
        {
            var oldBook = await _bookRepository.GetByIdAsync(id);

            if(oldBook != null)
            {
                oldBook.Author = book.Author;
                oldBook.Booktitle = book.Booktitle;
                oldBook.BookDescription = book.BookDescription;

                await _bookRepository.UpdateAsync(oldBook);

                return oldBook;
            }
            return null;
        }
    }
}
