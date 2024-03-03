using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Service;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoRepository _todoService;
        public TodoController(ITodoRepository repository)
        {
            _todoService = repository;
        }
        [HttpGet("{id?}")]
       public IActionResult GetToDo(int? id)
          
        {
            var mytodos = _todoService.AllToDos();
            if (id is null) return Ok(mytodos);
            mytodos = mytodos.Where(t => t.Id == id).ToList();

            return Ok(mytodos);
        }

        
    }
}
