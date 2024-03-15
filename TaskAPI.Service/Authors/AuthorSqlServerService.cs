using TaskApi.DataAccess;
using TaskAPI.Models;

namespace TaskAPI.Service.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();       
        public List<Aurthor> GetAllAuthors()
        {
            return _context.Aurthors.ToList();
        }

        public Aurthor GetAuthor(int id)
        {
            return _context.Aurthors.Find(id);
        }
    }
}

