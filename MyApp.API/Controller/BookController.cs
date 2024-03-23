using Microsoft.AspNetCore.Mvc;
using MyApp.DTO;
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
        public async Task<IEnumerable<GetBookDto>> Get()
        {
           return await _bookService.GetBooksAsync();
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public async Task<GetBookDto> Get(int id)
        {
            return await _bookService.GetBookAsync(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public async Task<GetBookDto> Post([FromBody] CreateBookDto bookDto)
        {
            return await _bookService.CreateBookAsync(bookDto);
        }

        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public async Task<GetBookDto> Put(int id, [FromBody] UpdateBookDto bookDto)
        {
            return await _bookService.UpdateBookAsync(id, bookDto);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _bookService.DeleteBookAsync(id);
        }
    }
}
