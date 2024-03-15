using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskApi.DataAccess;

namespace TaskAPI.Service.Todos
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDbContext _context = new TodoDbContext();
        public List<Todo> AllToDos()
        {
            return _context.Todos.ToList();
        }

        public Todo GetTodo(int id)
        {
            return _context.Todos.Find(id);
        }
    }
}
