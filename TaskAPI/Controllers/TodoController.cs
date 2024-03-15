using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Service.Todos;

namespace TaskAPI.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoRepository _todoService;
        public TodoController(ITodoRepository repository)
        {
            _todoService = repository;
        }

        [HttpGet]
       public IActionResult GetToDos()
          
        {
            var mytodos = _todoService.AllToDos();

            return Ok(mytodos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todo = _todoService.GetTodo(id);
                if (todo is null)
            {
                return NotFound();
            }
                return Ok(todo);
        }


        
    }
}
