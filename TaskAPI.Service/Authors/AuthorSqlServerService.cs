using Microsoft.IdentityModel.Tokens;
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

        public List<Aurthor> GetAllAuthors(string job, string search)
        {
            var authorCollection = _context.Aurthors as IQueryable<Aurthor>;

            // Apply job filter if provided
            if (!string.IsNullOrWhiteSpace(job))
            {
                job = job.Trim();
                authorCollection = authorCollection.Where(a => a.JobRole == job);
            }

            // Apply search filter if provided
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(a => a.FullName.Contains(search) || a.City.Contains(search));
            }

            return authorCollection.ToList();
        }

        public Aurthor GetAuthor(int id)
        {
            return _context.Aurthors.Find(id);
        }
    }
}

