using Microsoft.AspNetCore.Mvc;
using MyApp.IServices;
using MyApp.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        public readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }


        // GET: api/<AuthorController>
        [HttpGet]
        public Task<IEnumerable<Author>> Get()
        {
            return _authorService.GetAuthorAsync();
        }

        // GET api/<AuthorController>/5
        [HttpGet("{id}")]
        public async Task<Author> Get(int id)
        {
            return await _authorService.GetAuthorAsync(id);
        }

        // POST api/<AuthorController>
        [HttpPost]
        public async Task<Author> Post([FromBody] Author author)
        {
            return await _authorService.CreateAuthorAsync(author);
        }

        // PUT api/<AuthorController>/5
        [HttpPut("{id}")]
        public async Task<Author> Put(int id, [FromBody] Author author)
        {
            return await _authorService.UpdateAuthorAsync(id, author);
        }

        // DELETE api/<AuthorController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _authorService.DeleteAuthorAsync(id);
        }
    }
}
