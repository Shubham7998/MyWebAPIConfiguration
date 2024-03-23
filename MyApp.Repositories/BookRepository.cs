using MyApp.Data;
using MyApp.IRepositories;
using MyApp.Model;

namespace MyApp.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
