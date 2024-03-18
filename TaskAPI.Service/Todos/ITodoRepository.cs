using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Service.Todos
{
    public interface ITodoRepository
    {
        public List<Todo> AllToDos(int authorId);
        public Todo GetTodo(int authorId, int id);
        public Todo AddTodo(int authorId, Todo todo);
    }
}
