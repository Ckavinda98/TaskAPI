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
        public List<Todo> AllToDos();
        public Todo GetTodo(int id); 
    }
}
