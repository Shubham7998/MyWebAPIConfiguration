using MyApp.DTO;
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

        public async Task<GetBookDto> CreateBookAsync(CreateBookDto bookDto)
        {
            var book =  await _bookRepository.CreateAsync(new Book()
            {
                AuthorId = bookDto.AuthorId,
                BookDescription = bookDto.BookDescription,
                Booktitle = bookDto.BookTitle
            });

            return new GetBookDto(book.BookId, book.Booktitle, book.BookDescription);
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

        public async Task<GetBookDto> GetBookAsync(int id)
        {
            var book =  await _bookRepository.GetByIdAsync(id);
            return new GetBookDto(book.BookId, book.Booktitle, book.BookDescription);
        }

        public async Task<IEnumerable<GetBookDto>> GetBooksAsync()
        {
            var books =  await _bookRepository.GetAllAsync();

            var bookDto = books.Select(book => new GetBookDto(book.BookId, book.Booktitle, book.BookDescription));

            return bookDto;
        }

        public async Task<GetBookDto> UpdateBookAsync(int id, UpdateBookDto bookDto)
        {
            var oldBook = await _bookRepository.GetByIdAsync(id);

            if(oldBook != null)
            {
                oldBook.AuthorId = bookDto.AuthorId;
                oldBook.Booktitle = bookDto.BookTitle;
                oldBook.BookDescription = bookDto.BookDescription;

                await _bookRepository.UpdateAsync(oldBook);

                return new GetBookDto(oldBook.BookId, oldBook.Booktitle, oldBook.BookDescription);
            }
            return null;
        }
    }
}
