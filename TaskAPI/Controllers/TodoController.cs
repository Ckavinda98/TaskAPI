using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Models;
using TaskAPI.Service.Models;
using TaskAPI.Service.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/authors/{authorID}/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoRepository _todoService;
        private readonly IMapper _mapper;
        public TodoController(ITodoRepository repository, IMapper mapper)
        {
            _todoService = repository;
            _mapper = mapper;
        }

        [HttpGet]
       public ActionResult<ICollection<TodoDto>> GetToDos(int authorId)
          
        {
            var mytodos = _todoService.AllToDos(authorId);

            var mappedTodos = _mapper.Map<ICollection<TodoDto>>(mytodos);

            return Ok(mappedTodos);
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todo = _todoService.GetTodo(authorId, id);
                if (todo is null)
            {
                return NotFound();
            }

            var mappedTodo = _mapper.Map<TodoDto>(todo);
                return Ok(mappedTodo);
        }

        [HttpPost]
        public ActionResult<TodoDto> CreateToDo(int authorId, CreateTodoDto todo)
        {
            var todoEntity = _mapper.Map<Todo>(todo);
            var newTodo = _todoService.AddTodo(authorId, todoEntity);
            var todoForReturn = _mapper.Map<TodoDto>(newTodo);

            return CreatedAtRoute("GetTodo", new { authorId = authorId, id = todoForReturn.Id },
                todoForReturn);

        }

        
    }
}
