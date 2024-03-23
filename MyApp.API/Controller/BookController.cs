using Microsoft.AspNetCore.Mvc;
using MyApp.IServices;
using MyApp.Model;
using MyApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        // GET: api/<BookController>
        [HttpGet]
        public async Task<IEnumerable<Book>> Get()
        {
           return await _bookService.GetBooksAsync();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<Book> Get(int id)
        {
            return await _bookService.GetBookAsync(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<Book> Post([FromBody] Book book)
        {
            return await _bookService.CreateBookAsync(book);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public async Task<Book> Put(int id, [FromBody] Book book)
        {
            return await _bookService.UpdateBookAsync(id, book);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _bookService.DeleteBookAsync(id);
        }
    }
}
