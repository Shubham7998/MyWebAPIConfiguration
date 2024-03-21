using MyApp.Data;
using MyApp.IRepositories;
using MyApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyAppDbContext _dbContext) : base(_dbContext)
        {

        }
    }
}
