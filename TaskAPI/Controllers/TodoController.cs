using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TaskAPI.Models;
using TaskAPI.Service;

namespace TaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private TodoService _todoService;
        public TodoController()
        {
            _todoService = new TodoService();
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
