using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Service.Authors
{
    public interface IAuthorRepository
    {
        public List<Aurthor> GetAllAuthors();

        public Aurthor GetAuthor(int id);
    }
}
