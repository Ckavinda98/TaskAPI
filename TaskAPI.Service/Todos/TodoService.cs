using TaskAPI.Models;

namespace TaskAPI.Service.Todos
{
    public class TodoService : ITodoRepository
    {
        public List<Todo> AllToDos(int authorId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Example 1",
                Description = "Test",
                Created = DateTime.Now,
                Deu = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo1);

            var todo2 = new Todo

            {
                Id = 2,
                Title = "Example 1",
                Description = "Test",
                Created = DateTime.Now,
                Deu = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo2);

            var todo3 = new Todo

            {
                Id = 2,
                Title = "Example 1",
                Description = "Test",
                Created = DateTime.Now,
                Deu = DateTime.Now.AddDays(5),
                Status = TodoStatus.New

            };
            todos.Add(todo3);

            return todos;

        }

        public Todo GetTodo(int authorID, int id)
        {
            throw new NotImplementedException();
        }
    }
}
