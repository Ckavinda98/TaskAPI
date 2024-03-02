using TaskAPI.Models;

namespace TaskAPI.Service
{
    public class TodoService
    {
        public List<Todo> AllToDos()
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
    }
}
