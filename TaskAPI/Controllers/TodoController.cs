using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
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

        [HttpGet("{id}")]
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


        
    }
}
